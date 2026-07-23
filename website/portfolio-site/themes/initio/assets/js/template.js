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


// MAKES TITLE CLICKABLE IN CARD COMPONENT (TRIGGERS MODAL)
document.addEventListener('DOMContentLoaded', () => {
  document.querySelectorAll('.card .content-title').forEach(title => {
    title.addEventListener('click', e => {
      const card = e.target.closest('.card');
      const trigger = card.querySelector('.flex-items[data-toggle="modal"]');
      if (trigger) {
        trigger.click();
      }
    });
  });
});

// MAKES CARD LAUNCH MODAL ON ENTER PRESS WHEN FOCUSED
document.addEventListener('DOMContentLoaded', () => {
  document.querySelectorAll('.flex-items').forEach(item => {
    item.addEventListener('keydown', e => {
      if (e.key === 'Enter') {
        item.click();
      }
    });
  });
});


// ACCORDION CODE - CLOSES ACCORDION WHEN ANOTHER OPENS
document.addEventListener("DOMContentLoaded", function () {
  const items = document.querySelectorAll(".accordion-item");

  // (No items will be open on page load)
  items.forEach(item => {
    const summary = item.querySelector("summary");
    const wrapper = item.querySelector(".accordion-wrapper");
    let animating = false;

    summary.addEventListener("click", function (e) {
      e.preventDefault();
      if (animating) return;
      animating = true;

      const isOpen = item.hasAttribute("open");

      // Close all other items (true accordion behavior)
      items.forEach(other => {
        if (other !== item && other.hasAttribute("open")) {
          const otherWrapper = other.querySelector(".accordion-wrapper");
          const height = otherWrapper.scrollHeight;

          otherWrapper.style.maxHeight = height + "px";

          requestAnimationFrame(() => {
            otherWrapper.style.transition = "max-height 0.3s ease";
            otherWrapper.style.maxHeight = "0px";
          });

          otherWrapper.addEventListener("transitionend", function cleanup() {
            other.removeAttribute("open");
            otherWrapper.style.maxHeight = "0px";
            otherWrapper.style.transition = "";
            otherWrapper.removeEventListener("transitionend", cleanup);
          });
        }
      });

      if (!isOpen) {
        // OPEN animation
        item.setAttribute("open", "");
        const height = wrapper.scrollHeight;

        wrapper.style.maxHeight = "0px";

        requestAnimationFrame(() => {
          requestAnimationFrame(() => {
            wrapper.style.transition = "max-height 0.3s ease";
            wrapper.style.maxHeight = height + "px";
          });
        });

        wrapper.addEventListener("transitionend", function cleanup() {
          wrapper.style.maxHeight = "none";
          wrapper.style.transition = "";
          wrapper.removeEventListener("transitionend", cleanup);
          animating = false;
        });

      } else {
        // CLOSE animation
        const height = wrapper.scrollHeight;
        wrapper.style.maxHeight = height + "px";

        requestAnimationFrame(() => {
          wrapper.style.transition = "max-height 0.3s ease";
          wrapper.style.maxHeight = "0px";
        });

        wrapper.addEventListener("transitionend", function cleanup() {
          item.removeAttribute("open");
          wrapper.style.maxHeight = "0px";
          wrapper.style.transition = "";
          wrapper.removeEventListener("transitionend", cleanup);
          animating = false;
        });
      }
    });
  });
});
