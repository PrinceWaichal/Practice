// JavaScript source code
// Create a "close" button and append it to each list item
var List = document.getElementsByTagName( "li" );
var i;
for ( i = 0; i < List.length; i++ )
{
    var span = document.createElement( "Span" );
    var text = document.createTextNode( "\u00D7" );
    span.className = "Close";
    span.appendChild( text );
    List[i].appendChild( span );
}

// Click on a close button to hide the current list item
var close = document.getElementsByName( "close" );
var i;
for ( i = 0; i < close.length; i++ )
{
    close[i].onclick=function()
    {
        var div = this.par
    }
}