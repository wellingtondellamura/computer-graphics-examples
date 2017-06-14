
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

//Desenhar formas geométricas
   //RETANGULO
   ctx.rect(20,20,150,100); //retangulo (x,y,w,h);
   ctx.stroke();

   fillRect()
   strokeRect()
   clearRect()

   //CIRCULO
   ctx.beginPath();
   ctx.arc(100,75,50,0,2*Math.PI); //https://www.w3schools.com/tags/canvas_arc.asp
   //center(100,75) startAngle(0) endAngle(2*pi)
   ctx.stroke();

   //POLIGONOS
   //triangulo
   var c = document.getElementById("myCanvas");
   var ctx = c.getContext("2d");
   ctx.beginPath();
   ctx.moveTo(50,50);
   ctx.lineTo(90,100);
   ctx.lineTo(10,100);
   ctx.lineTo(50,50);
   ctx.stroke();
   ctx.fill();


ctx.lineWidth = "1"; //largura da linha
ctx.strokeStyle='rgb(255,0,0)'; //cor da linha
ctx.stroke(); //linha

ctx.fillStyle='rgb(255,0,0)'; //cor do preenchimento
ctx.fill();   //preenchimento


//Personalizar o preenchimento
   //color
   var c = document.getElementById('myCanvas');
   var ctx = c.getContext('2d');

   ctx.rect(10,10,400,400);
   ctx.fillStyle='rgb(255,0,0)'; //'rgb(255,0,0)' | 'red' | '#FF0000'
   ctx.fill();

   //gradient
      //linear
      var c = document.getElementById('myCanvas');
      var ctx = c.getContext('2d');

      var gradient = ctx.createLinearGradient(0,0,170,0);
      gradient.addColorStop("0","magenta");
      gradient.addColorStop("0.5","blue");
      gradient.addColorStop("1.0","red");

      ctx.rect(10,10,400,400);
      ctx.fillStyle=gradient;
      ctx.fill();
      //radial
      //https://www.w3schools.com/tags/canvas_createradialgradient.asp
      var c=document.getElementById("myCanvas");
      var ctx=c.getContext("2d");

      var grd=ctx.createRadialGradient(75,50,5,90,60,100);
      // x0 	The x-coordinate of the starting circle of the gradient
      // y0 	The y-coordinate of the starting circle of the gradient
      // r0 	The radius of the starting circle
      // x1 	The x-coordinate of the ending circle of the gradient
      // y1 	The y-coordinate of the ending circle of the gradient
      // r1 	The radius of the ending circle
      grd.addColorStop(0,"red");
      grd.addColorStop(1,"white");

      // Fill with gradient
      ctx.fillStyle=grd;
      ctx.fillRect(10,10,150,100);

   //pattern
   var img = new Image();
   img.src = 'http://bgpatterns.com/patterns/v/x/4/pattern.png';

   var c=document.getElementById("myCanvas");
   var ctx=c.getContext("2d");

   var pat=ctx.createPattern(img,"repeat");
   ctx.rect(10,10,400,400);
   ctx.fillStyle=pat;
   ctx.fill();

//Sombra
   var c = document.getElementById('myCanvas');
   var ctx = c.getContext('2d');

   ctx.shadowBlur=20;
   ctx.shadowColor="black";
   ctx.shadowOffsetX = 15;
   ctx.shadowOffsetY = 15;

   ctx.rect(10,10,400,400);
   ctx.fillStyle='rgb(255,0,0)'; //'rgb(255,0,0)' | 'red' | '#FF0000'
   ctx.fill();

//Desenhar imagem

   var c = document.getElementById('myCanvas');
   var ctx = c.getContext('2d');


   var img = new Image();
   img.src = 'https://image.freepik.com/fotos-gratis/sorriso-de-lhama_2270977.jpg';

   ctx.drawImage(img,10,10, 200, 200);

  
