<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmln s="http://www.w3.org/1999/xhtml">
<head>
<title>MySQL Server Information</title>
<meta http-equiv="content-type" content="text/html; charset=iso-8859-1"/>
</head>
<body>
<h1>MySQL Database Server Information</h1>

<?php
$servername = "localhost";
$username = "root";
$password = "";
$table = "bug_reports";

// Create connection
$conn = new mysqli($servername, $username, $password);

// Check connection
if ($conn->connect_error) {
    die("Unable to connect to the database server : " . $conn->connect_error);
}

// Create database
$sql = "CREATE DATABASE hardware_bugs";
if ($conn->query($sql) === TRUE) {
    echo "Database created successfully";
} 
else {
    echo "Error creating database: " . $conn->error;
}	
	// Change db to "this" db
	$conn -> select_db("hardware_bugs");
	
	if ($result = $conn -> query("SELECT DATABASE()")) {
	  $row = $result -> fetch_row();
	  echo " <br/>Selected database is " . $row[0];
	  $result -> close();
	}
	
	$sql = "CREATE TABLE IF NOT EXISTS $table (
			
			countID   SMALLINT NOT NULL AUTO_INCREMENT PRIMARY KEY,
			prod_name VARCHAR(40), 
			prod_vers VARCHAR(40),
			prod_type VARCHAR(40),
			prod_os   VARCHAR(40),
			problem   VARCHAR(100)
			
			)";
	
	if ($conn->query($sql) === TRUE) {
		echo "<br/>Table bug reports created successfully";
		
		$ProdName = stripslashes($_POST['prod_name']);
		$ProdVers = stripslashes($_POST['prod_vers']);
		$ProdType = stripslashes($_POST['prod_type']);
		$OS       = stripslashes($_POST['prod_os']);
		$Problem  = stripslashes($_POST['problem']);
		
		$sql = "INSERT INTO $table VALUES( NULL, '$ProdName', '$ProdVers', '$ProdType', '$OS', '$Problem')";
		if(mysqli_query($conn, $sql)){
			echo "<br/>Records updated successfully";
		}
		else
			echo "<br/>updating table did not work";
	
	} 
	else {
		echo "<br/>Error creating table: " . $conn->error;
	}
		
$conn->close();

?>

<p><a href="ShowTable.php">View Report Table</a></p>
<p><a href="AddReport.html">Add Another Report</a></p>
<p><a href="UpdateReport.html">Update An Entry</a></p>

</body>
</html>


