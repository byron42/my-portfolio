// (( DEVELOPMENT ))
//-------------------------------------------------

// $(window).on('load', function () {
//     if (!sessionStorage.getItem('shown-modal')) {
//       $('#myModal').modal('show');
//       sessionStorage.setItem('shown-modal', 'true');
//     }
//   });

//   $(document).ready(function () {
//     $("#myModal").modal('show');
// });




// (( PRODUCTION ))
// -------------------------------------------------

$(document).ready(function(){
  if (!sessionStorage.getItem('shown-modal')){
    $('#myModal').modal('show');
    sessionStorage.setItem('shown-modal', 'true');
  }
});