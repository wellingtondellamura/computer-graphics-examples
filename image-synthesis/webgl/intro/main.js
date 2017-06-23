var gl = null;
var positionAttribIndex = 0;

function setupWebGL(){
  var canvas = document.getElementById("output");
  gl = canvas.getContext("webgl");
}

function setupWhatToDraw(){
  var positions = [
    0.0, 0.0,
    1.0, 0.0,
    0.0, 1.0,
    1.0, 1.0,
    0.0, 0.0
  ];
  var typedPositions = new Float32Array(positions);
  var positionsBuffer = gl.createBuffer();
  gl.bindBuffer(gl.ARRAY_BUFFER,positionsBuffer);
  gl.bufferData(gl.ARRAY_BUFFER,typedPositions, gl.STATIC_DRAW);
  gl.enableVertexAttribArray(positionAttribIndex);
  gl.vertexAttribPointer(positionAttribIndex, 2, gl.FLOAT, false, 0, 0);
}

function setupHowToDraw(){
  //vertex shader
  var vsSource="\
    attribute vec2 aPosition;                 \n\
                                              \n\
    void main(void) {                         \n\
      gl_Position = vec4(aPosition, 0.0, 1.0);\n\
    }                                         \n\
  ";
  var vertexShader = gl.createShader(gl.VERTEX_SHADER);
  gl.shaderSource(vertexShader, vsSource);
  gl.compileShader(vertexShader);

  //fragmentshader
  var fsSource="\
    void main(void){                          \n\
      gl_FragColor = vec4(0.0, 0.0, 1.0, 1.0);\n\
    }                                         \n\
  ";
  var fragmentShader = gl.createShader(gl.FRAGMENT_SHADER);
  gl.shaderSource(fragmentShader,fsSource);
  gl.compileShader(fragmentShader);

  //program
  var program = gl.createProgram();
  gl.attachShader(program, vertexShader);
  gl.attachShader(program, fragmentShader);
  gl.bindAttribLocation(program, positionAttribIndex,"aPosition");
  gl.linkProgram(program);
  gl.useProgram(program);
}

function draw(){
  gl.clearColor(0.0, 0.0, 0.0, 1.0);
  gl.clear(gl.COLOR_BUFFER_BIT);
  gl.drawArrays(gl.LINE_LOOP, 0, 5);
}

function helloDraw(){
  setupWebGL();
  setupWhatToDraw();
  setupHowToDraw();
  draw();
}

window.onload=helloDraw;
