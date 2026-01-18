jQuery(document).ready(function ($) {

	var my_nav = $('.navbar-sticky');
	// grab the initial top offset of the navigation 
	var sticky_navigation_offset_top = my_nav.offset().top;

	// our function that decides weather the navigation bar should have "fixed" css position or not.
	var sticky_navigation = function () {
		var scroll_top = $(window).scrollTop(); // our current vertical position from the top

		// if we've scrolled more than the navigation, change its position to fixed to stick to top, otherwise change it back to relative
		if (scroll_top > sticky_navigation_offset_top) {
			my_nav.addClass('stick');
		} else {
			my_nav.removeClass('stick');
		}
	};

	var initio_parallax_animation = function () {
		$('.parallax').each(function (i, obj) {
			var speed = $(this).data('parallax-speed');
			if (speed) {
				var background_pos = '-' + (window.pageYOffset / speed) + "px";
				$(this).css('background-position', 'center ' + background_pos);
			}
		});
	}

	// run our function on load
	sticky_navigation();

	// and run it again every time you scroll
	$(window).scroll(function () {
		sticky_navigation();
		initio_parallax_animation();
	});

});

/*

	// focus button click-hide
$(document).ready(function(){
	//alert("hello");
//if ($("#image").is(":visible")){
	//alert("content is visible");
  $(".info-icon").click(function(){
	$("#image").removeClass("hide-content-box");
	alert("this is the info button");

	$("#content").focus();
	
	$("#content").focus(function() {
        $("#image").addClass("hide-content-box");
    });


	
  });
//}




});

$(document).ready(function() {
  const $toggleButton = $('#image > div.icon-position > div > img.info-icon');
  const $infoPanel = $('#content');

  $toggleButton.on('click', function() {
    $infoPanel.toggleClass('hide');
  });
});

*/



/*
document.addEventListener('DOMContentLoaded', function() {
  const toggleButton = document.getElementsByClassName('info-icon');
  const infoPanel = document.getElementById('image');

  toggleButton.addEventListener('click', function() {
    infoPanel.classList.toggle('show');
  });
});




$(document).ready(function() {
//if($("#image").height() != 0){
  $(".info-icon").click(function() {
	alert('this is correct')
    // Find the input field with the class 'my-input' and trigger the blur event
    $('#image').removeClass('focus');
  });
//}
});


*/

/*
$(document).ready(function() {

	$("#image").on('transitionend', function() {
         //doSomething
		 $('.info-icon').on('click', function() {
			e.preventDefault();

			const $image = $('#image');

			if ($image.is(':focus')) {
			// Collapse
			$image.blur();
			} 
  });


    });
  
});
*/
