$(function(){if($(".radio-inline input:checked, .radio input:checked").parents(".radio, .radio-inline").addClass("is-active"),$(".radio-inline input, .radio input").on("click",function(){var e=$(this).attr("name");$('input[name="'+e+'"]').each(function(){$(this).is(":checked")?$(this).parents(".radio, .radio-inline").addClass("is-active"):$(this).parents(".radio, .radio-inline").removeClass("is-active")})}),$(".checkbox-inline input:checked, .checkbox input:checked").parents(".checkbox, .checkbox-inline").addClass("is-active"),$(".checkbox-inline input, .checkbox input").on("click",function(){$(this).is(":checked")?$(this).parents(".checkbox, .checkbox-inline").addClass("is-active"):$(this).parents(".checkbox, .checkbox-inline").removeClass("is-active")}),$("#game-page1").length>0){$("#game-page1").show(),$(".js-extraschifting").on("click",function(e){$(this).is(":checked")?$("#extraschifting").addClass("is-active"):$("#extraschifting").removeClass("is-active")});var e=$("#wedstrijdform").validate({onkeyup:!1,onfocusout:!1,highlight:function(e){$(e).closest(".form-group").addClass("has-error")},unhighlight:function(e){$(e).closest(".form-group").removeClass("has-error")},errorElement:"span",wrapper:"div",errorClass:"help-block",errorPlacement:function(e,i){i.parent(".input-group").length?e.insertAfter(i.parent()):i.parent(".form-inline").length?e.insertAfter(i.parent()):i.parents(".radio").length?e.insertAfter(i.parents(".radio").siblings(":last-child")):i.parents(".radio-inline").length?e.insertAfter(i.parents(".radio-inline").siblings(":last-child")):i.parents(".checkbox").length?e.insertAfter(i.parents(".checkbox label")):e.insertAfter(i)}});$("#game-page1 .btn").on("click",function(i){e.form()?($("#game-page2").show(),$("#game-page1").hide()):$("#game-page1 .alert").show()}),$("#game-page2 .btn").on("click",function(i){e.form()?($("#game-page3").show(),$("#game-page2").hide()):$("#game-page2 .alert").show()}),$("form").on("submit",function(i){return e.form()?!0:($("#game-page3 .alert").show(),!1)})}});