// adapt containerwidth to screen size
var containerwidth = function(selector) {
    return parseInt($(selector).width())
};

function containerDim(selector, dim) {
    return parseInt(d3.select(selector).style(dim))
}

$(function() {
    $('a[href*="http"]').attr('target', '_blank');
    $('.nav a[href="'+document.location.pathname+'"]').parent('li').attr('class', 'active');    
});