#include <GL/glut.h>

void drawWindow(){
    glClearColor(0, 0, 0, 1);
    glClear(GL_COLOR_BUFFER_BIT);

    glBegin(GL_POINTS);
    for (int i = 0; i < 100; i++){
        glColor3f(0.5, 1.0, 0.5);
        glVertex2d(0.0, (double)i/100);
        glVertex2d(0.0, -(double)i/100);
        glColor3f(0.5, 1.0, 1.0);
        glVertex2d((double)i/100, 0.0);
        glVertex2d(-(double)i/100, 0.0);
        glColor3f(1.0, 0.5, 1.0);
        glVertex2d((double)i/100, -(double)i/100);
        glVertex2d(-(double)i/100, (double)i/100);
        glColor3f(1.0, 1.0, 0.5);
        glVertex2d((double)i/100, (double)i/100);
        glVertex2d(-(double)i/100, -(double)i/100);
    }
    glEnd();

    glFlush();
}

int main(int argc, char *argv[]){
    glutInit(&argc, argv);
    glutInitWindowSize(1800, 1000);
    glutInitWindowPosition(0, 0);

    glutCreateWindow("::Ola Mundo OpenGL::");
    glutDisplayFunc(drawWindow);
    glutMainLoop();
    return 1;
}
