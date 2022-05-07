<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Two Trains</title>
<meta http-equiv="content-type" content="text/html; charset=iso-8859-1"/>
</head>
<body>

<?php

	$DisplayForm = TRUE;
	$SpeedA = "";
	$SpeedB = "";
	$Distance = "";

	if(isset($_POST['Submit'])){
		$SpeedA = $_POST['SpeedA'];
		$SpeedB = $_POST['SpeedB'];
		$Distance = $_POST['Distance'];
		
		// validation conditions and form display based on conditions
		if((is_numeric($SpeedA) && $SpeedA > 0) && (is_numeric($SpeedB) && $SpeedB > 0) && (is_numeric($Distance) && $Distance > 0)){
			$DisplayForm = FALSE;
		}
				
		else{
			echo "<h2>You need to enter a numeric value and it has to be larger than 0.</h2>\n";
			$DisplayForm = TRUE;
		}
	}	
	
	if($DisplayForm){
	?>
		<form name="TwoTrains" action="TwoTrains.php" method="post">
			<p>Enter Speed Of Train A: <input type="text" name="SpeedA" value="<?php echo $SpeedA; ?>" /></p>
			<p>Enter Speed Of Train B: <input type="text" name="SpeedB" value="<?php echo $SpeedB; ?>" /></p>
			<p>Enter Distance Between Trains: <input type="text" name="Distance" value="<?php echo $Distance; ?>" /></p>
			<p><input type="reset" value="Clear Form" /> &nbsp; &nbsp; <input type="submit" name="Submit" value="Send Form" /></p>
		</form>	
	<?php
	}
	
	else{
		
		//equations rounded off to 2 decimals
		$DistanceA = round((($SpeedA / $SpeedB) * $Distance) / (1 + ($SpeedA / $SpeedB)), 2);
		$DistanceB = round($Distance - $DistanceA, 2);
		$TimeA = round($DistanceA / $SpeedA, 2);
		$TimeB = round($DistanceB / $SpeedB, 2);
		echo"<h2>Thank you for entering all numbers greater than zero.</h2>\n";
		echo"<p>Train A traveled $DistanceA, Train B traveled $DistanceB</p>\n";
		echo"<p>Train A Time: $TimeA, Train B Time: $TimeB</p>\n";
		echo"<p><a href=\"TwoTrains.php\">Try Again?</a></p>\n";
	}
?>

</body>
</html>