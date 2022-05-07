<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Web Order</title>
<meta http-equiv="content-type" content="text/html; charset=iso-8859-1"/>
</head>
<body>
<h1>Make A Web Order</h1>
<p>
<?php
$Dir = "OnlineOrders";
if (is_dir($Dir)){
	if(isset($_POST['save'])){
	
		$Total =  ($_POST['numPencil'] * 1) + ($_POST['numPen'] * 2) + ($_POST['numMark'] * 3)
				  + ($_POST['numCray'] * 3) + ($_POST['numPaper'] * 5);
		
		$SaveString = stripslashes ($_POST['numPencil']) . " units of pencils were ordered  ($1/unit)\n";
		$SaveString .= stripslashes ($_POST['numPen']) . " units of pens were ordered     ($2/unit)\n";
		$SaveString .= stripslashes ($_POST['numMark']) . " units of markers were ordered  ($3/unit)\n";
		$SaveString .= stripslashes ($_POST['numCray']) . " units of crayons were ordered  ($3/unit)\n";
		$SaveString .= stripslashes ($_POST['numPaper']) . " units of reams were ordered    ($5/unit)\n\n";
			$SaveString .= "Order Total: $" . $Total;
		
		$TimeStamp = date("mdy.hms");
		
		/* File name is " MonthDayYear.HourMinuteSecond.txt" */
		$SaveFileName = "$Dir/$TimeStamp.txt";
		
		$fp = fopen($SaveFileName,"ab");
		if($fp === FALSE){
			echo "There was an error creating \"" . htmlentities($SaveFileName) . "\".<br />\n";
		}
		
		else{
			if (fwrite($fp, $SaveString)>0)
				echo "Successfully wrote to file \"" . htmlentities($SaveFileName) . "\"<br />\n";
			else 
				echo "There was an error writing to file \"" . htmlentities($SaveFileName) . "\"<br />\n";
			fclose($fp);
		}
	}
}
?>
</p>

<form action="WebOrder.php" method=post>
	<table border=5>
		<tr>
			<td width=100>Item<br>&nbsp;</td>
			<td width=300>Description<br>&nbsp;</td>
			<td width=100>Price<br>&nbsp;</td>
			<td width=10>Quantity<br>&nbsp;</td>
		</tr>
		<tr>
			<td>Pencils</td>
			<td>units of pencils</td>
			<td>$1</td>
			<td>
				<select name="numPencil">
					<?php
						for ($i=0; $i<=10; $i++)
						{
					?>
								<option value="<?php echo $i;?>"><?php echo $i;?></option>
					<?php
						}
					?>
				</select>
			</td>
		</tr>
		<tr>
			<td>Pens</td>
			<td>units of pens</td>
			<td>$2</td>
			<td>
				<select name="numPen">
					<?php
						for ($i=0; $i<=10; $i++)
						{
					?>
								<option value="<?php echo $i;?>"><?php echo $i;?></option>
					<?php
						}
					?>
				</select>
			</td>
		</tr>
		<tr>
			<td>Markers</td>
			<td>units of markers</td>
			<td>$3</td>
			<td>
				<select name="numMark">
					<?php
						for ($i=0; $i<=10; $i++)
						{ 
					?>
								<option value="<?php echo $i;?>"><?php echo $i;?></option>
					<?php
						}
					?>
				</select>
			</td>
		</tr>
		<tr>
			<td>Crayons</td>
			<td>units of crayons</td>
			<td>$3</td>
			<td>
				<select name="numCray">
					<?php
						for ($i=0; $i<=10; $i++)
						{
					?>
								<option value="<?php echo $i;?>"><?php echo $i;?></option>
					<?php
						}
					?>
				</select>
			</td>
		</tr>
		<tr>
			<td>Paper</td>
			<td>units of paper</td>
			<td>$5</td>
			<td>
				<select name="numPaper">
					<?php
						for ($i=0; $i<=10; $i++)
						{
					?>
								<option value="<?php echo $i;?>"><?php echo $i;?></option>
					<?php
						}
					?>
				</select>
			</td>
		</tr>
			<td colspan="5" align="right"><br>
			<input type="submit" name="save" value="Enter Order">
			<input type="reset" name="reset" value="Reset form">
			<br>
			<br>
			</td>
		</tr>
	</table>
</form>
</body>
</html>