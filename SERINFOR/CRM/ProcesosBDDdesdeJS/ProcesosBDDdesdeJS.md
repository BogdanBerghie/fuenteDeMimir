# Llamadas a Procesos de BDD almacenados en FlexyGo desde JS
Si tenemos un proceso de BDD creado en FlexyGo, podemos realizar una llamada desde JS para poder ejecutarlo. Para ello llamaremos a la funcion **flexygo.nav.execProccess**


Estos son sus parametros: 

*flexygo.nav.execProcess(processname, objectname, objectwhere, defaults, processparams, targetid, excludeHist, triggerElement, callBack, showProgress)*


Estos son los parámetros más relevantes.
+ processname: Nombre del proceso en FlexyGo
+ objectname: Nombre del Objeto en FlexyGo (normalmente ira en null si es un procedimiento de BDD)
+ objectwhere: Where de la clave primaria del objeto (normalmente ira en null si es un procedimiento de BDD)
+ processparams: parámetros a introducir en el proceso. Estos iran en formato JSON de la siguiente manera:
[{'Key':'nombredelparametro','Value':tuvalor}, {'Key':'nombredelparametro2','Value':tuvalor2},{'Key':'nombredelparametro3','Value':tuvalor3}]

Para los demás valores, tomar la siguiente ejecuccion como referencia:
**flexygo.nav.execProcess('prueba_procedure_',null,null,null,[{'Key':'IdOferta','Value':1}, {'Key':'IdLinea','Value':1},{'Key':'orden','Value':50}], null, false, $(this), null,false);**
