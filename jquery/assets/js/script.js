$(".accor").click(function(){
    $(this).toggleClass("active")
    $(this).parent().find(".arrow").toggleClass("arrow-rotate")
    $(this).parent().find(".content").slideToggle(300)
})

