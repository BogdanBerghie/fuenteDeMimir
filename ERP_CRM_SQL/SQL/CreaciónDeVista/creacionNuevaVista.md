## Crear nueva vista
No es complicado pero hay detalles que con el teimpo se pueden olvidar.

La BBDD del ERP tiene mil y una vistas que se pueden utilizar pero hay que tener en cuenta de que si necesitas modificar alguna vista existente lo que ahy que hacer es **crear una nueva** y ponerle el mismo nombre con un **_pers** al final ya que si desde *Ahora* cambian algo de una vista que hayamos modificado perderemos nuestra modifivacion por la suya.

###### 1. creación de la nueva vista
Como ejemplo usaremos esta tabla "*VDLG_Facturas_Cli_Cab_Col* " a la que tenemos que añadirle unos datos así que simplemente cambiamos el *ALTER* por *CREATE* y añaimos las modificaciones que se neceste.

```sql
ALTER  VIEW [dbo].[VDLG_Facturas_Cli_Cab_Col]

AS
SELECT 
	Fcc.*, 
	F.SubTotalEuros as Total,
	F.TotalEuros as TotalIVA,
	F.BaseAnticiposConFactura,
	F.TotalAnticiposConFactura
FROM 
	VDLG_Facturas_Cli_Cab Fcc
	LEFT JOIN vFacturas_Cli_Total_Anticipos  F ON Fcc.IdFactura =F.IdFactura
GO
```

Ya con los cambios relizados solo quedaría confiramar la creación de la nueva tabla y darle permisos.

```sql
CREATE VIEW [dbo].[VDLG_Facturas_Cli_Cab_Col_pers]

AS
SELECT 
	Fcc.*, 
	F.SubTotalEuros as Total,
	F.TotalEuros as TotalIVA,
	F.BaseAnticiposConFactura,
	F.TotalAnticiposConFactura,
	FP.Descrip as FormadePago,
	SF.Descrip as SeriedeFactura,
	ED.Nombre as Creadopor,
	E.Nombre as Empresa
FROM 
	VDLG_Facturas_Cli_Cab Fcc
	LEFT JOIN vFacturas_Cli_Total_Anticipos  F ON Fcc.IdFactura =F.IdFactura
	LEFT JOIN FormasPago FP ON Fcc.FormaPago = FP.IdFormaPago
	LEFT JOIN Series_Facturacion SF on Fcc.SerieFactura = SF.SerieFactura
	LEFT JOIN Empleados_Datos ED on Fcc.IdEmpleado = ED.IdEmpleado
	LEFT JOIN Empresa E on Fcc.IdEmpresa = E.IdEmpresa
GO
--mencion especial a los permisos para que no se olviden
zpermisos vClientes_TPV_pers
```
###### 2. Hacer que el ERP utilice la nueva vista 

Ya solo faltaría configurar que el ERP utilize la nueva vista que simplemente es cambiar la consulta de:
>Select * from VDLG_Facturas_Cli_Cab_Col

a 

>Select * from VDLG_Facturas_Cli_Cab_Col_pers

![Redefinir la consulta](/ERP_CRM_SQL\SQL\CreaciónDeVista\img\Screenshot_1.png?raw=true)