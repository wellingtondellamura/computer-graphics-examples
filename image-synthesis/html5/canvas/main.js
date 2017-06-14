function drawTriangle(x,y){
  var cv = document.getElementById("cv");
  var ctx = cv.getContext("2d");
  ctx.beginPath();
  ctx.moveTo(x,y);
  ctx.lineTo(x-150,y+200);
  ctx.lineTo(x+150,y+200);
  ctx.lineTo(x,y);


  ctx.shadowBlur=50;
  ctx.shadowColor="black";
  ctx.shadowOffsetX = 50;
  ctx.shadowOffsetY = 50;

  ctx.strokeStyle='rgb(255,0,0)';
  ctx.lineCap = 'round';
  ctx.lineWidth = 6;
  ctx.lineJoin = 'round';
  ctx.miterLimit = 5;
  ctx.stroke();
  ctx.fillStyle='rgb(0,255,0)';
  ctx.fill();
}
function drawRect(x,y){
  var c = document.getElementById('cv');
  var ctx = c.getContext('2d');
  var img = new Image();
  img.src = 'https://image.freepik.com/fotos-gratis/sorriso-de-lhama_2270977.jpg';
  ctx.drawImage(img,x,y,img.width, img.height);
}
