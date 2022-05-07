<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Scholarship Form</title>
<meta http-equiv="content-type" content="text/html; charset=iso-8859-1"/>
</head>
<body>

<?php

$hoursWorked = $_POST['hours'];
$payRate = $_POST['rate'];

//paycheck vars
$totalPay;
$overtime = $hoursWorked - 40;
$otPay = ($payRate * 1.5) * $overtime;

if($hoursWorked > 40){
	$totalPay = ($hoursWorked * $payRate) + $otPay;
}
else
	$totalPay = $hoursWorked * $payRate;

echo "You worked " .$hoursWorked. " hours<br>";
echo "Your Hourly rate was $".$payRate. "<br>";
echo "Your total pay was $".$totalPay. " (Overtime pay was $" .$otPay.")<br>";

?>

</body>
</html>

<p>

</p>