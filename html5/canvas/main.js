function draw(x,y){
  var cv = document.getElementById("cv");
  var ctx = cv.getContext("2d");
  ctx.beginPath();
  ctx.moveTo(x,y);
  ctx.lineTo(x-50,y+100);
  ctx.lineTo(x+50,y+100);
  ctx.lineTo(x,y);
  ctx.strokeStyle='rgb(255,0,0)';
  //ctx.lineCap = 'round';
  ctx.lineWidth = 5;
  ctx.lineJoin = 'miter';
  ctx.miterLimit = 5;
  ctx.stroke();
  //ctx.fill();
}
