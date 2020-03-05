$(document).ready(function () {
	

	$('.sidenav').sidenav({ edge: 'right' });
	$('.tabs').tabs();
	$('.collapsible').collapsible();
	$('.modal').modal();
	$('.materialboxed').materialbox();
	$('.parallax').parallax();
	$('.slider').slider();
	$('.fixed-action-btn').floatingActionButton();
	$('textarea#message').characterCounter();
	$(".dropdown-trigger").dropdown();
	$('select').formSelect();

	// Initiate the wowjs animation library
	new WOW().init();

	$("#schedule .tabs .tab a").on("click", function () {
		var href = $(this).attr("href");
		//var id = href.replace("#", "");


		$(href).addClass("wow fadeInUp animated");
		$(href).attr("style", "visibility: visible; animation-name: fadeInUp;");
	});

	$('.venobox').venobox({
		framewidth: '900px',        // default: ''
		frameheight: '600px',       // default: ''
		border: '2px',             // default: '0'
		titleattr: 'data-title',    // default: 'title'
		infinigall: true            // default: false
	}); 

	$('.owl-carousel').owlCarousel({
		loop: true,
		margin: 10,
		responsiveClass: true,
		responsive: {
			0: {
				items: 1,
				nav: true
			},
			600: {
				items: 3,
				nav: false
			},
			1000: {
				items: 5,
				nav: true,
				loop: false
			}
		}
	});


	// Back to top button
	$(window).scroll(function () {
		if ($(this).scrollTop() > 100) {
			$('.fixed-action-btn').fadeIn('slow');
		} else {
			$('.fixed-action-btn').fadeOut('slow');
		}
	});


	$("body").on("click", ".view-detail", function () {

		var id = $(this).data("id");
		console.log(id);

		$.ajax({
			url: "https://localhost:44369/api/speaker/" + id,
			method: "get",
			success: function (response) {
				console.log(response);
			},
			error: function (errorr) {
				console.log(error);
			}
		})
	});

	srollToHandler();

	function srollToHandler() {
		// Add smooth scrolling to all links
		$("nav a.jump-anim").on('click', animate);
		$(".footer-links a").on('click', animate);
		$(".btn-floating").on('click', animate);
	}

	function animate(event) {
		// Make sure this.hash has a value before overriding default behavior
		if (this.hash !== "") {
			// Prevent default anchor click behavior
			event.preventDefault();

			// Store hash
			var hash = this.hash;
			console.log(hash);
			//console.log(hash);
			// Using jQuery's animate() method to add smooth page scroll
			// The optional number (800) specifies the number of milliseconds it takes to scroll to the specified area
			$('html, body').animate({
				scrollTop: $(hash).offset().top
			}, 800, function () {

				// Add hash (#) to URL when done scrolling (default click behavior)
				window.location.hash = hash;
			});
		} // End if
	}
});