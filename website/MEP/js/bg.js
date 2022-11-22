jQuery(function () {
  // Preload BG images
  function preload(arrayOfImages) {
    $(arrayOfImages).each(function () {
      $("<img/>")[0].src = this;
      // Alternatively you could use:
      // (new Image()).src = this;
    });
  }

  // Usage:
  preload([
    "./images/backgrounds/pets.jpg",
    "./images/backgrounds/families.jpg",
    "./images/backgrounds/weddings.jpg",
    "./images/backgrounds/children.jpg",
    "./images/backgrounds/business.jpg",
  ]);

  //------------------------------------------------------------------------------------
  // Portfolio BG images (fade into each other and stay until next nav item is hovered)
  //------------------------------------------------------------------------------------

  $("#pet_bg").hover(function () {
    // this.focus();
    $("#body").css({
      background:
        "url(./images/backgrounds/pets.jpg) no-repeat top center fixed",
    });
  });

  $("#family_bg").hover(function () {
    // this.focus();
    $("#body").css({
      background:
        "url(./images/backgrounds/families.jpg) no-repeat top center fixed",
    });
  });

  $("#wedding_bg").hover(function () {
    this.focus();
    $("#body").css({
      background:
        "url(./images/backgrounds/weddings.jpg) no-repeat top center fixed",
    });
  });

  $("#children_bg").hover(function () {
    this.focus();
    $("#body").css({
      background:
        "url(./images/backgrounds/children.jpg) no-repeat top center fixed",
    });
  });

  $("#business_bg").hover(function () {
    this.focus();
    $("#body").css({
      background:
        "url(./images/backgrounds/business.jpg) no-repeat top center fixed",
    });
  });
});