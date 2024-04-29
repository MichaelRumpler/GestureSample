
$(window).bind("load resize", function () {
	var mainNav = $("header nav");
	var body = $("body");
	if (window.innerWidth < 768) {
		mainNav.addClass("navbar-fixed-top");
		body.addClass("navbarFixedTop");
	} else {
		mainNav.removeClass("navbar-fixed-top");
		body.removeClass("navbarFixedTop");
	}
});

$('h2,h3').each(function (i) {
	var id = $(this).attr('id');
	if (id)
	{
		$(this).before('<a name="' + id + '"></a>');
		var href = $('<a href="#' + id + '">' + $(this).text() + '</a>');
		$(this).html(href);
	}
});

$('#sidebar').affix({
	offset: {
		top: function () {
			return (this.top = $('.bs-docs-sidebar').position().top)
		}
	}
})

$(window).load(function () {
	$(".compatibility td").each(function () {
		if (this.title)
		{
			//		<td data-title="ContentPage on Windows Phone" data-content="..." data-container="body" data-toggle="popover" data-placement="bottom" data-trigger="click hover">
			var tr = this.parentNode;
			var tds = tr.children;
			var element = $(tds[0]).text();
			var i = 1;
			while (i < tds.length && tds[i] !== this)
				i++;
			element += i<tds.length ? (" on " + ["iOS", "Android", "UWP", "WPF", "MacOS"][i - 1]) : "";

			this.setAttribute("data-content", this.title);
			this.setAttribute("data-title", element);
			this.title = element;
			this.setAttribute("data-container", "body");
			this.setAttribute("data-toggle", "popover");
			this.setAttribute("data-placement", "bottom");
			this.setAttribute("data-trigger", "click hover");
		}
	});
	$(function () {
		$('[data-toggle="popover"]').popover()
	})
});
