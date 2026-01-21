Informe de Auditoría de Sistemas
Fecha: 21 de enero de 2026


Auditor: Equipo de Auditoría  

1. Hallazgos 


H-01 (Seguridad): Uso de int.Parse en la línea 82 sin validación previa, lo que causa un crash si el input es texto.



H-02 (Seguridad): Ausencia total de bloques try-catch para manejar errores de desbordamiento o formato.


H-03 (Documentación): El código carece de comentarios técnicos o documentación interna.


H-04 (Lógica): La lógica de comparación es débil; no se filtran números negativos para la edad.

2. Riesgos 

Riesgo de Disponibilidad: Un usuario malintencionado o erróneo puede tirar el servicio ingresando datos basura.


Riesgo de Mantenibilidad: El crecimiento del código sin estándares dificultará futuras actualizaciones del pipeline DevOps.


3. Recomendaciones 

R-01: Implementar int.TryParse para asegurar que el valor ingresado es un entero válido antes de procesar.


R-02: Integrar el analizador Microsoft.CodeAnalysis.NetAnalyzers en el pipeline de CI/CD para automatizar estas reglas.