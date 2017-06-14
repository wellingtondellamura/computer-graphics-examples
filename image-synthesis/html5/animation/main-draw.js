function drawShip_(ship){
  var x = ship.x;
  var y = ship.y;
  context.beginPath();
  context.rect(x+5, y+50, 10, 50);
  context.rect(x+85, y+50, 10, 50);
  context.fillStyle = ship.gunColor;
  context.fill();

  context.beginPath();
  context.moveTo(x+0,y+100);
  context.lineTo(x+100,y+100);
  context.lineTo(x+50,y+40);
  context.lineTo(x+0,y+100);
  context.fillStyle = ship.shipColor;
  context.fill();
  context.lineWidth = 1;
  context.strokeStyle = ship.shipColor;
  context.stroke();

  context.beginPath();
  context.rect(x+30, y+30, 40, 70);
  context.fillStyle = ship.shipColor;
  context.fill();
  context.lineWidth = 1;
  context.strokeStyle = ship.shipColor;
  context.stroke();

  context.beginPath();
  context.moveTo(x+30,y+30);
  context.lineTo(x+70,y+30);
  context.lineTo(x+50,y+10);
  context.lineTo(x+30,y+30);
  context.fillStyle = ship.shipColor;
  context.fill();
  context.lineWidth = 1;
  context.strokeStyle = ship.shipColor;
  context.stroke();

  context.beginPath();
  context.rect(x+20, y+100, 10, 10);
  context.rect(x+70, y+100, 10, 10);
  context.fillStyle = ship.boosterColor;
  context.fill();
}

function getShip(ship){
  console.log(ship);
  var cv = document.createElement('canvas');
  cv.width = 100;
  cv.height = 110;
  var ctx = cv.getContext("2d");
  var x = 0;
  var y = 0;
  ctx.beginPath();
  ctx.rect(x+5, y+50, 10, 50);
  ctx.rect(x+85, y+50, 10, 50);
  ctx.fillStyle = ship.gunColor;
  ctx.fill();

  ctx.beginPath();
  ctx.moveTo(x+0,y+100);
  ctx.lineTo(x+100,y+100);
  ctx.lineTo(x+50,y+40);
  ctx.lineTo(x+0,y+100);
  ctx.fillStyle = ship.shipColor;
  ctx.fill();
  ctx.lineWidth = 1;
  ctx.strokeStyle = ship.shipColor;
  ctx.stroke();

  ctx.beginPath();
  ctx.rect(x+30, y+30, 40, 70);
  ctx.fillStyle = ship.shipColor;
  ctx.fill();
  ctx.lineWidth = 1;
  ctx.strokeStyle = ship.shipColor;
  ctx.stroke();

  ctx.beginPath();
  ctx.moveTo(x+30,y+30);
  ctx.lineTo(x+70,y+30);
  ctx.lineTo(x+50,y+10);
  ctx.lineTo(x+30,y+30);
  ctx.fillStyle = ship.shipColor;
  ctx.fill();
  ctx.lineWidth = 1;
  ctx.strokeStyle = ship.shipColor;
  ctx.stroke();

  ctx.beginPath();
  ctx.rect(x+20, y+100, 10, 10);
  ctx.rect(x+70, y+100, 10, 10);
  ctx.fillStyle = ship.boosterColor;
  ctx.fill();
  return cv;
}

function drawShip(ship){
  if (ship.canvas == undefined){
    ship.canvas = getShip(ship);
  }

  var cv = ship.canvas;
  context.drawImage(cv, ship.x, ship.y, cv.width, cv.height);
}

function drawBackground(){
  context.drawImage(sky,0,0, canvas.width, canvas.height);
}

function moveShip(event){
  var k = event.code;
  if (k == 'KeyA'){
    ship.x -= ship.distance;
  } else if (k == 'KeyD'){
    ship.x += ship.distance;
  } else if (k == 'KeyS'){
    ship.y += ship.distance;
  } else if (k == 'KeyW'){
    ship.y -= ship.distance;
  }
}

function update(){

}

function draw(){
  drawShip(ship);
}

function animate(time) {
  context.clearRect(0,0,canvas.width,canvas.height);
  drawBackground();
  update();
  draw();
  window.requestNextAnimationFrame(animate);
}

var canvas = document.getElementById("screen");
canvas.width = window.innerWidth-25;
canvas.height = window.innerHeight-25;
var context = canvas.getContext("2d");

var sky = new Image();
    sky.src = "space1.jpg";

  var ship = {
    x: 50,
    y: 75,
    shipColor: "#ffffff",
    boosterColor: "#aaaaaa",
    gunColor: "#ff0000",
    distance: 5,
    canvas: undefined
  };

window.requestNextAnimationFrame =  window.requestAnimationFrame
  || window.webkitRequestAnimationFrame
  || window.mozRequestAnimationFrame
  || window.oRequestAnimationFrame
  || window.msRequestAnimationFrame;

animate(+new Date());
