var myRectangle = {
  x: 0,
  y: 75,
  width: 100,
  height: 50
};

var lastTime = 0;

function calculateFps() {
  var now = +new Date,
  fps = 1000 / (now - lastTime);
  lastTime = now;
  return fps;
}

function drawFPS(ms){
  var now = +new Date;
  var fps = calculateFps();
  if (now - fpsUpdate > ms) {
    fpsUpdate = now;
    fpsValue = fps;
  }
  context.fillStyle = 'red';
  context.font = '16px monospace';
  context.fillText(fpsValue.toFixed() + ' fps', 10, 20);
}

function drawBackground(){
  context.drawImage(sky,0,0, canvas.width, canvas.height);
}

function update(){
  var newX = 0;
  if (reverse){
    newX = myRectangle.x-10;
    if(newX > 0) {
      myRectangle.x = newX;
    } else {
      reverse = false;
    }
  } else {
    newX = myRectangle.x+10;
    if(newX < canvas.width - myRectangle.width) {
      myRectangle.x = newX;
    } else {
      reverse = true;
    }
  }
}

function draw(){
  context.beginPath();
  context.rect(myRectangle.x, myRectangle.y, myRectangle.width, myRectangle.height);
  context.fillStyle = 'red';
  context.fill();
  context.lineWidth = 1;
  context.strokeStyle = 'black';
  context.stroke();
}

function animate(time) {
  context.clearRect(0,0,canvas.width,canvas.height);
  drawBackground();
  update();
  draw();
  drawFPS(1000);
  window.requestNextAnimationFrame(animate);
}

var canvas = document.getElementById("animation-screen");
canvas.width = window.innerWidth-25;
canvas.height = window.innerHeight-25;
var context = canvas.getContext("2d");
var reverse = false;
var fpsUpdate = 0;
var fpsValue = 0;
var sky = new Image();
    sky.src = "sky.jpg";

window.requestNextAnimationFrame =  window.requestAnimationFrame
  || window.webkitRequestAnimationFrame
  || window.mozRequestAnimationFrame
  || window.oRequestAnimationFrame
  || window.msRequestAnimationFrame;

animate(+new Date());
