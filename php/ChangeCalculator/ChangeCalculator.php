<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<meta http-equiv="content-type" content="text/html; charset=iso-8859-1"/>


<?php
//BRING IN THE CLASS
 include 'Change.php';
 ?>

<head>
    <title>Change</title>
</head>
<body>
<h1>Buy Something</h1>

<form name="buyit" action="" method="post">
    <h3>Cost: <input type="text" name="cost">
    <h3>Cash Tendered:<input type="text" name="tendered"></h3>
    <p><input type="submit" name="submit" value="Purchase"></p>
</form>

<?php
//MAKE THE OBJECT
$return = new Change();

//CALL THE FUNCTION FROM THE CLASS
$return->make_change();
?>

</body>
</html>