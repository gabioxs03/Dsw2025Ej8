# Ejercicio N 8
## Desarrollo de Software
### Herencia y propiedades

## INTEGRANTES
### 56099 - Diaz Alvillos, Bernabe - bdiazalvillos@gmail.com
### 53447 - Samaniego, Gabriel - gabrielsamaniego2016@gmail.com
### 56115 - Ralle, Felicitas - felicitasralle2009@gmail.com


1. Realizar una bifurcacion (fork) del [repositorio](https://github.com/ing-software-frt-utn/dsw2025ej8).
2. Crear una rama de larga duracion development.
3. Clonar el repositorio bifurcado y trabajar sobre la rama development.
4. Refactorizar el c�digo aplicando herencia seg�n el caso.
5. Reemplazar los metodos getters y setters, y campos por propiedades, tener en cuenta la accesibilidad en cada caso.
6. Respetar que al crear una cuenta bancaria se reciba el nemero y el saldo en el constructor.
7. La tasa de interes se debe indicar al inicializar la instancia de cuenta, pero no mediante el constructor (seteada en 5%).
8. El limite de descubierto se debe indicar al inicializar la instancia de cuenta, pero no mediante el constructor.
9. Agregar las siguientes reglas:
	* El monto recibido por cualquier operacion no puede ser menor o igual a 0, de lo contrario generar una excepcion del tipo MontoNoValido.
	* Cualquier operacion se debe realizar si la cuenta esta activa, en cualquier otro caso generar una excepcion del tipo CuentaNoActiva.
	* Se debe contar con saldo para realizar un retiro, caso contrario debe generar una excepcion SaldoInsuficiente y la cuenta debe quedar suspendida. Tener en cuenta el limite de descubierto si corresponde.
10. Instanciar 4 cuentas (dos de cada tipo) y realizar diferentes operaciones que permitan comprobar todas las funciones posibles.
11. Recorrer las 4 cuentas creadas y mostrar por consola un resumen de cada una, que incluya numero, tipo y saldo (utilizar una clase anonima).

Consideraciones:
- Las excepciones deben incluir los siguiente mensajes:
- MontoNoValido -> El monto ingresado no es valido para la operacion solicitada.
- CuentaNoActiva -> No se puede operar con la cuenta {estado} (reemplazar por el estado en el que se encuentra).
- SaldoInsuficiente -> La cuenta no cuenta con saldo para la operacion solicitada. Fue suspendida.
- La aplicacion no debe interrumpir su funcionamiento si se produce una excepcion.
