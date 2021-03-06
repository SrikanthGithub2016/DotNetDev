﻿<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>@ViewData("Title")</title>
    <link href="@Url.Content("~/Content/default.css")" rel="stylesheet" type="text/css" />
	<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.4/jquery.min.js" type="text/javascript"></script>
    <script type="text/javascript">
    	$(function () {
    		$('.popup').click(function (e) {
    			$('#content').attr('src', $(this).attr('href'));
    			$('#container, #close').show();
    			e.preventDefault();
    		});
    		$('#close').click(function (e) {
    			$('#content').attr('src', '');
    			$('#container, #close').hide();
    			e.preventDefault();
    		});
    	});
	</script>
</head>

<body>
    @RenderBody()

	<a href="#" id="close">close</a>
	<div id="container"><iframe id="content"></iframe></div>
</body>
</html>
