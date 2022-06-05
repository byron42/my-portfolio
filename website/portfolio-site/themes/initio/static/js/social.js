// ============================================================================ dropdown toggle ==========
//                      toggles between hiding and showing contact icons
// =======================================================================================================
  function contactIcons() {
    document.getElementById("myDropdown").classList.toggle("show");
  }
  
  // Close the dropdown if the user clicks outside of it
  window.onclick = function(event) {
    if (!event.target.matches('.dropbtn')) {
      var dropdowns = document.getElementsByClassName("dropdown-content");
      var i;
      for (i = 0; i < dropdowns.length; i++) {
        var openDropdown = dropdowns[i];
        if (openDropdown.classList.contains('show')) {
          openDropdown.classList.remove('show');
        }
      }
    }
  }

// =============================================================================== scroll hide ==========
//                       WORKS (would like it to disappear on stop-scrollig)
// =======================================================================================================
function onScroll() {
  var dropdowns = document.getElementsByClassName("dropdown-content");
    var i;
    for (i = 0; i < dropdowns.length; i++) {
      var openDropdown = dropdowns[i];
      if (openDropdown.classList.contains('show')) {
        openDropdown.classList.remove('show');
      }
    }
    // dropdowns.classList.remove()
}
window.onscroll = function() {onScroll()};
// =======================================================================================================


                                                // doesn't work (tried for better transitions)

                                          // let dropdown = document.getElementById('myDropdown');
                                          // document.getElementById('handleDrop').onclick = function ()
                                          // {
                                          //   dropdown.classList.toggle('show');
                                          // }


// =============================================================================== mouse hide ==========
//   WORKS (needs to be changed to whenever the next parent section is entered if possible or not use)
// =======================================================================================================
// 
function mouseOver() {
  var dropdowns = document.getElementsByClassName("dropdown-content");
    var i;
    for (i = 0; i < dropdowns.length; i++) {
      var openDropdown = dropdowns[i];
      if (openDropdown.classList.contains('show')) {
        openDropdown.classList.remove('show');
      }
    }
}
// (only works on pages with subheader ie home ..disabled)


// document.getElementById("subheader").onmouseover = function() {mouseOver()};


// =======================================================================================================


/***********************/
/****** TEMPLATES  *****/
/***********************/

// document.getElementById("demo").onmouseover = function() {mouseOver()};
// document.getElementById("demo").onmouseout = function() {mouseOut()};

// function mouseOut() {
//   document.getElementById("demo").style.color = "black";
// }

// function mouseOver() {
//   document.getElementById("demo").style.color = "red";
// }