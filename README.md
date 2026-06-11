# SISTEMA DE EMPAQUETADO AUTOMATIZADO 1.0
*Descripcion*
Sistema de empaquetado automatizado desarrollado en C# Windows Forms y
Arduino para simular una linea de produccion compuesta por 
una banda transportadora y un brazo robotico.

La aplicacion permite controlar los dispositivos mediante comunicacion serial,
monitorear el estado del sistema en tiempo real y registrar eventos de operacion.

Esta version (1.0) implementa el control y monitoreo basico del brazo robotico,
asi como la conexion con la banda transportadora para futuras aplicaciones del sistema

---------------------------------------------------------------------------------------

# CARACTERISTICAS

*Software*
• C#
• .NET 8
• Windows Forms
• Visual Studio 2026

*Hardware*
• Arduino
• Servomotores
• Banda Transportadora
• Sensores De Deteccion
• Comunicacion Serial UART

---------------------------------------------------------------------------------------

# ARQUITECTURA DEL SISTEMA

| Componente | Responsabilidad |
|------------|----------------|
| Aplicación Windows Forms | Interfaz gráfica y coordinación del sistema |
| BrazoController | Comunicación serial con el brazo robótico |
| Arduino Brazo | Control de servomotores y rutina de empaquetado |
| Arduino Banda | Control de motores y sensores de la banda |
| Puerto Serial | Canal de comunicación entre PC y hardware |


---------------------------------------------------------------------------------------

# FLUJO DE OPERACION
1. El usuario actualiza la lista de puertos disponibles.
2. Se conecta el brazo robótico.
3. Se conecta la banda transportadora.
4. El operador inicia una rutina desde la interfaz.
5. La aplicación envía un comando al Arduino.
6. El brazo ejecuta la secuencia programada.
7. Arduino envía mensajes de estado:
  • INICIO
  • FIN
8. La aplicación actualiza el estado visual.
9. Se incrementa el contador de cajas procesadas.

---------------------------------------------------------------------------------------

# INTERFAZ

La aplicación permite:

• Seleccionar puertos COM.

• Conectar dispositivos.

• Ejecutar pruebas del brazo.

• Monitorear estados.

• Visualizar eventos del sistema.

• Consultar el número de cajas procesadas.

---------------------------------------------------------------------------------------


# ESTADO DEL PROYECTO
Versión actual: 1.0

**Funcionalidades implementadas:**

• Comunicación serial.

• Control del brazo robótico.

• Registro de eventos.

• Monitoreo de estados.

• Conteo de producción.

**Próximas mejoras:**

• Automatización completa del ciclo de empaquetado.

• Integración de sensores.

• Control automático de la banda transportadora.

• Sistema de alarmas y manejo de errores.

• Dashboard de producción.

