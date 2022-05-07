<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>Guest Book</title>
<meta http-equiv="content-type" content="text/html; charset=iso-8859-1"/>
</head>
<body>

<h1>Guest Book</h1>
<?php

// deletes last entry
if(isset($_GET['action'])){
	if ((file_exists("Visitors/visitors.txt")) && (filesize("Visitors/visitors.txt")!=0)){
			$VisitorArray = file("Visitors/visitors.txt");
		
		// selecting options here
		switch($_GET['action']){
			case 'Delete First':
				array_shift($VisitorArray);
				break;
			case 'Delete Last':
				array_pop($VisitorArray);
				break;
			case 'Delete Message':
				if(isset($_GET['message'])){
					$Index = $_GET['message'];
				unset($VisitorArray[$Index]);
				$VisitorArray = array_values($VisitorArray);
				}
				break;
            case 'Sort Ascending':
                sort($VisitorArray);
                break;
            case 'Sort Descending':
                rsort($VisitorArray);
                break;
		}
		
		if(count($VisitorArray)>0){
			$NewMessages = implode($VisitorArray);
			$MessageStore = fopen("Visitors/visitors.txt","wb");
			if($MessageStore === false)
				echo "There was an error updating the guest book\n";
			else{
				fwrite($MessageStore, $NewMessages);
				fclose($MessageStore);
			}
		}
		else
			unlink("Visitors/visitors.txt");
	}
}

// creates the table
if((!file_exists("Visitors/visitors.txt")) || (filesize("Visitors/visitors.txt") == 0))
	echo "<p>There are no guests in the guest book.<p>\n";

else{
	$VisitorArray = file("Visitors/visitors.txt");
	echo "<table style=\"background-color:lightgray\" border=\"1\" width=\"50%\">\n";
	
	$count = count($VisitorArray);
	for($i=0; $i<$count; ++$i){
		$CurrMsg = explode("~", $VisitorArray[$i]);
	echo "<tr>\n";
	echo "<td width=\"5%\" style=\"text-align:center; font-weight:bold\">" . ($i + 1) . "</td>\n"; 
	echo "<td width=\"70%\" ><span style=\"font-weight:bold\">Name:</span>" . htmlentities($CurrMsg[0]) . "<br/>\n"; 
	echo "<span style=\"font-weight:bold\">Email:</span>" . htmlentities($CurrMsg[1]) . "<br/>\n"; 
	echo "<td width=\"10\" style=\"text-align:center\">" . "<a href='GuestBook.php?"
			. "action=Delete%20Message&" . "message=$i'>" . "Delete This Message</a></td>\n";
	echo "</tr>\n";
	}
	echo "</table>\n";
}
?>

<p>
<a href="AddGuest.php">Add Guest</a>
<br />
<a href="GuestBook.php?action=Sort%20Ascending">Sort Guests A-Z</a>
<br/>
<a href="GuestBook.php?action=Sort%20Descending">Sort Guests Z-A</a>
<br/>
<a href="GuestBook.php?action=Delete%20First">Delete First Guest</a>
<br />
<a href="GuestBook.php?action=Delete%20Last">Delete Last Guest</a>
</p>

</body>
</html>

