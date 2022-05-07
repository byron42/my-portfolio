<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Guessing Game</title>
<meta http-equiv="content-type" content="text/html; charset=iso-8859-1"/>
</head>
<body>
<h1>Can you guess the random number between 1 and 100?</h1>
<?php
session_start();

if (!isset($_POST["guess"])) {
     //Initialize session variables
   	 $_SESSION["count"] = 0; 
     $message = "";
	 $_SESSION ["magicNumber"] = 0;
	 
     $_SESSION["magicNumber"] = rand(0,100);
     echo $_SESSION["magicNumber"];
} 

else if ($_POST["guess"] > $_SESSION["magicNumber"]) { //greater than
    $message = $_POST["guess"]." is too big - try a smaller number.";
    $_SESSION["count"]++; //Declare the variable $count to increment by 1.

} 

else if ($_POST["guess"] < $_SESSION["magicNumber"]) { //less than
    $message = $_POST["guess"]." is too small - try a bigger number.";
    $_SESSION["count"]++; //Declare the variable $count to increment by 1.

} 

else { // must be equivalent
    $_SESSION["count"]++;
    $message = "You guessed the right number in ".$_SESSION["count"]." tries!"; 
    unset($_SESSION["count"]);
	
	// reset count to 0
	$_SESSION["count"] = 0; 
}
?>
<h3><?php echo $message; ?></h3>
<form action="" method="POST">
	<p><strong>Enter guess:</strong> <input type="text" name="guess">
	<input type="submit" value="Submit your guess "/></p>
	<p><input type="hidden" name="magicNumber" value="<?php echo $_SESSION["magicNumber"]; ?>" ></p>
</form>

<h3 style="color:green">Number of guesses: <?php echo $_SESSION["count"]; ?></h3>

<form action="GuessingGame.html">
	<p><input type="submit" value="Start Over"/> </p>
</form>
  
</body>
</html>



