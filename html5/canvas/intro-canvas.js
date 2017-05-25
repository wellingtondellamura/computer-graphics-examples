
//Desenhar linhas
var c = document.getElementById("myCanvas");
var ctx = c.getContext("2d");
ctx.moveTo(0,50);
ctx.lineTo(10,100);
ctx.lineTo(20,50);
ctx.lineTo(30,100);
ctx.lineTo(40,50);
ctx.lineTo(50,100);
ctx.stroke();

//Personalizar cor da linha
 ctx.strokeStyle='rgb(255,0,0)';
 ctx.strokeStyle='red';
 ctx.strokeStyle='#FF0000';

//estilo da linha
   ctx.lineCap="butt|round|square"; //https://www.w3schools.com/tags/playcanvas.asp?filename=playcanvas_lineCap

//largura da linha
   ctx.lineWidth=10;

//junção das linhas
   ctx.beginPath();
   ctx.lineJoin="round|bevel|miter";
ctx.lineWidth=10; //https://www.w3schools.com/tags/playcanvas.asp?filename=playcanvas_lineJoin
   ctx.moveTo(20,20);
   ctx.lineTo(100,50);
   ctx.lineTo(20,100);
   ctx.stroke();
   //miter limit
   //https://www.w3schools.com/tags/playcanvas.asp?filename=playcanvas_miterLimit
   ctx.miterLimit=2;

//Várias linhas
   var c = document.getElementById("myCanvas");
   var ctx = c.getContext("2d");

   ctx.beginPath();
   ctx.lineWidth = "5";
   ctx.strokeStyle = "green";
   ctx.moveTo(0, 75);
   ctx.lineTo(250, 75);
   ctx.stroke();

   ctx.beginPath();
   ctx.strokeStyle = "purple";
   ctx.moveTo(50, 0);
   ctx.lineTo(150, 130);
   ctx.stroke();

//


//Desenhar linhas de um retângulo
ctx.strokeRect(20,20,150,100);
