<?php

class Change{
	private $money;
	private $cost;
	private $tendered;
	private $change;
	
	//set functions
	function set_money($money) {$this->money = $money;}
	function set_cost($cost) {$this->cost = $cost;}
	function set_tendered($tendered) {$this->tendered = $tendered;}
	function set_change($change) {$this->change = $change;}
	
	
	//get functions
	function get_money() {return $this->money;}
	function get_cost() {return $this->cost;}
	function get_tendered() {return $this->tendered;}
	function get_change() {return $this->change;}
	
	
	// function to calculate user input
	public function make_change(){
		if (isset($_POST['submit'])){

			$money = [100,50,20,10,5,2,1,0.50,0.20,0.10,0.05,0.02,0.01];

			//get values
			$cost = $_POST['cost'];
			$tendered = $_POST['tendered'];
			echo '<hr>';
			printf('You bought something for <strong>$%1.2f</strong> and paid <strong>$%2.2f</strong>',$cost,$tendered);
			
			//figure the change
			$change = $tendered - $cost;
			printf('<p>That makes <strong>$%1.2f</strong> change</p>',$change);
			echo '<hr>';
			
			
			if ($change >= 0){
				echo '<p>Your change is made up of: ';
				
				//paid enough
				for ($i=0;$i<count($money);$i++){
					while ($change >= $money[$i]){
						echo '<strong>$'. $money[$i] .',</strong> ';
						$change = bcsub($change,$money[$i],2);
					}
				}
			} 
			else {
				
				//if not enough
				echo '<h4 style="color:red">You dont have enough money!</h4>';
			}
		}
		else {
			echo '<p>Enter an amount then press the button</p>';
		}
	}
}
?>
