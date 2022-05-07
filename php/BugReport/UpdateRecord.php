<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>MySQL Server Information</title>
<meta http-equiv="content-type" content="text/html; charset=iso-8859-1"/>
</head>
<body>
<h1>Table For Database</h1>

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

	// Change db to "this" db
	$conn -> select_db("hardware_bugs");
	
	if ($result = $conn -> query("SELECT DATABASE()")) {
	  $row = $result -> fetch_row();
	  echo " <br/>Selected database is " . $row[0];
	  $result -> close();
	}
	
	$ID       = stripslashes($_POST['countID']);
	$ProdName = stripslashes($_POST['prod_name']);
	$ProdVers = stripslashes($_POST['prod_vers']);
	$ProdType = stripslashes($_POST['prod_type']);
	$OS       = stripslashes($_POST['prod_os']);
	$Problem  = stripslashes($_POST['problem']);
			
	$sql = "REPLACE INTO $table  VALUES ($ID, '$ProdName', '$ProdVers', '$ProdType', '$OS', '$Problem')";

	if ($conn->query($sql) === TRUE) {
		echo "<br/>Record updated successfully";
	} else {
		echo "<br/>Error updating record: " . $conn->error;
	}

	echo "<br/><br/>"; // SPACER

	// OUTPUT THE TABLE 
	$sql = "SELECT countID, prod_name, prod_vers, prod_type, prod_os, problem FROM bug_reports";
	$result = $conn->query($sql);

	if ($result->num_rows > 0) {
		echo "<table border = 1>
				<tr>
					<th width = 30>ID</th>
					<th width = 200>Product Name</th>
					<th width = 200>Product Version</th>
					<th width = 200>Product Type</th>
					<th width = 200>OS</th>
					<th width = 300>Problem Desc.</th>
				</tr>";
				
		// output data of each row
		while($row = $result->fetch_assoc()) {
			echo "<tr>
					<td>".$row["countID"]."</td>
					<td>".$row["prod_name"]."</td>
					<td>".$row["prod_vers"]."</td>
					<td>".$row["prod_type"]."</td>
					<td>".$row["prod_os"]."</td>
					<td>".$row["problem"]."</td>
				  </tr>";
		}
		echo "</table>";
	} 
	else{
		echo "0 results";
	}
$conn->close();

?>
<p><a href="AddReport.html">Add another report</a></p>
<p><a href="UpdateReport.html">Update another report</a></p>

</body>
</html>


