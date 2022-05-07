<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Post Message</title>
<meta http-equiv="content-type" content="text/html; charset=iso-8859-1"/>
</head>
<body>
<?php

if (isset($_POST['submit'])){
	$Name = stripslashes($_POST['name']);
	$Email = stripslashes($_POST['email']);
	// replace '~' with '-'
	$Name = str_replace("~", "-", $Name);
	$Email = str_replace("~", "-", $Email);
    
	$ExistingName = array();
    if(file_exists("Visitors/visitors.txt") && filesize("Visitors/visitors.txt") > 0) {
        $VisitorArray = file("Visitors/visitors.txt");
        $count = count($VisitorArray);
        for ($i = 0; $i < $count; ++$i) {
            $CurrMsg = explode("~", $VisitorArray[$i]);
            $ExistingName[] = $CurrMsg[0];
        }
    }
    if(in_array($Name, $ExistingName)){
        echo "<p>The name you entered already exists!<br/>\n";
        echo "Please enter a new name and try again.<br/>\n";
        echo "Your entry was not saved. </p>";
            $Name = "";
			$Email = "";
    }
	else {
        $VisitorRecord = "$Name~$Email\n";
        $VisitorFile = fopen("Visitors/visitors.txt", "ab");
        if ($VisitorFile === FALSE)
            echo "There was an error saving your message!\n";
        else {
            fwrite($VisitorFile, $VisitorRecord);
            fclose($VisitorFile);
            echo "Your message has been saved.\n";
            $Name ="";
			$Email = "";
        }
    }
}
else{
    $Name = "";
    $Email = "";
}
?>

<h1>Add New Guest</h1>
<hr />
<form action="AddGuest.php" method = "POST">

	<span style="font-weight:bold">Name:</span>
	<input type="text" name="name" value="<?php echo $Name; ?>" />

	<span style="font-weight:bold">Email:</span>
	<input type="text" name="email" value="<?php echo $Email; ?>"/>
	<br/>
	<br/>

	<input type="submit" name="submit" value="Add Guest" />
	<input type="reset" name="reset" value="Reset Form"/>
</form>
<hr/>
<p><a href="GuestBook.php">View Guest Book</a><p/>


</html>