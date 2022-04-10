jQuery(function(){
    $('.pet_bg').hover(function(){
        $(".pet").fadeIn();
    }, function() {
        // $(".pet").fadeOut("slow");
    })
	
	$('.family_bg').hover(function(){
        $(".family").fadeIn();
    }, function() {
        $(".family").fadeOut("slow");
    })
	
	$('.children_bg').hover(function(){
        $(".children").fadeIn();
    }, function() {
        $(".children").fadeOut("slow");
    })
	
	$('.wedding_bg').hover(function(){
        $(".wedding").fadeIn();
    }, function() {
        $(".wedding").fadeOut("slow");
    })
	
	$('.business_bg').hover(function(){
        $(".business").fadeIn();
    }, function() {
        $(".business").fadeOut("slow");
    })
    
	$('.menu-item-2').hover(function(){
        $(".bg2").fadeIn();
    }, function() {
        $(".bg2").fadeOut("slow");
    })
})

$(document).ready(function(){
    $('#wrapper').fadeIn();
});