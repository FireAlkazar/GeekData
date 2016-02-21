$(function(){
    var props = {
        drawing: {
            defaultLabelColor: '#fff',
            defaultLabelSize: 12,
            defaultLabelBGColor: '#fff',
            defaultLabelHoverColor: '#000',
            labelThreshold: 10,
            defaultEdgeType: 'curve'
        },
        graph: {
            minNodeSize: .5,
            maxNodeSize: 25,
            minEdgeSize: 1,
            maxEdgeSize: 1
        },
        forceLabel: 1,
        type: 'directed'
    }

    visgexf.init('sig', gexf, props, function() {
        var filterid = 'paradigms';
        var filters = visgexf.getFilters([filterid]);
    });
});