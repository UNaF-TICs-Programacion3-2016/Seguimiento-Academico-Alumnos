Proyecto: Sistema de Seguimiento Académico de Alumnos Universitarios
========================================================================

## _Integrantes_

> * _Acosta, Carlos Alberto_
> * _Ayala, Leandro José_
> * _Degregorio, Nicolás Ezequiel_
> * _Salas, Mara Anabel_     

_Alumnos de Licenciatura en Tecnologías de la Información y la Comunicación - Cátedra: Programación III_       


# Introducción

El proyecto que tratamos de abordar se trata de un sistema de seguimiento académico de alumnos universitarios, con lo cual se quiere capturar el rendimiento académico y la situación en la que se encuentra cada alumno, a partir de un puntaje calculado por nuestro sistema mediante los datos almacenados en una base de datos diseñada especialmente para el sistema en sí.

## Objetivos

1. Detectar a aquellos alumnos con mayor probabilidad de dejar la carrera, de acuerdo al puntaje obtenido, o con mayor probabilidad de que se "estanque" debido a fallos en el transcurso de la misma. Esto servirá para saber a qué grupo de alumnos apoyar.     

2. Conocer el estado en la carrera de cada alumno, partiendo de un punto desde que se inscriben a la carrera, y siguiendolos en el transcurso de la cursada.     

3. Determinar cuales son las razones más comunes de disersión de alumnos en la carrera, para brindar contención temprana a aquellos que posean esas tendencias y evitar que abandonen la carrera.

## Alcance

Se tendran en cuenta las siguientes variables para determinar la situación del alumno:       

* __Antecedentes académicos:__ Los datos que se requieren al ingresar un alumno a la carrera son el promedio del secundario, colegio al que asistió y su orientación, año de ingreso y año de egreso (para determinar si terminó el colegio a término o no). Se calcularán estas variables agregandolas al promedio de secundario para tener un puntaje de partida o inicial.

* __Información del desempeño actual de los alumnos:__ Los datos sobre el desempeño en el curso de la carrera de los alumnos a tener en cuenta serán los exámenes rendidos, aprobados y desaprobados (incluidas las notas, diferenciando parciales de finales), materias regulares, libres, aprobadas que el alumno haya cursado, y asistencias por materias en relación con la cantidad de clases dictadas.

* __Antecedentes socio-económicos y personales:__ Estos datos serán aquellos que pueden influir en el desempeño de los estudiantes, incluyendo el estado laboral del alumno (si trabaja o no, y si lo hace, si interfiere con las horas de clase), el nivel de ingreso del alumno o del grupo familiar con el que convive, y en cuanto a datos personales, cualquier antecedente que pudiese influenciar al alumno, como situaciones de violencia familiar, ausencia de alguno de los padres, traumas por incidentes.

* __Razones de disersión:__ Se buscará registrar, cuando un alumno decide abandonar la carrera, el por que de esto, para tener enlistadas las razones más frecuentes por las que se abandona una carrera y que sirva de guía para evitar que otros alumnos caigan en esa tendencia.

El sistema se servirá de estos datos para calcular un puntaje el cual, mientras mayor sea representará que mejor es la situación del alumno. Se tomarán una serie de parámetros a partir de estos datos, cada uno con un puntaje a favor o en contra, por ejemplo, si un alumno tiene menos del 75% de asistencia tendría un - 1, en cambio si tiene más del 75% sería un + 1. Diferentes fórmulas se aplicarán a la obtención de un parámetro y verificar el puntaje a asignar.



## Expectativas del proyecto

Esperamos que nuestro proyecto se convierta en una base útil que sirva para una herramienta con posibilidad de implementación. A la vez nuestra mayor expectativa es la adquisición de experiencia para futuros proyectos y una mejor comprensión del paradigma de programación orientado a objetos y de la programación en sí misma.

