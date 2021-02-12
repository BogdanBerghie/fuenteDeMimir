# Añadir/modificar campos de filtrado.
###### 1. Preparar la vista.
Lo primero será identificar la vista y visualizarla a modificar. 
![Modificar vista](/ERP_CRM_SQL\ERP\añadirCampoFiltro\img\Screenshot_1.png "Modificar vista")
###### 2. Añadir el nuevo campo requerido a la visti con un left join.
Como explicacion rapida el nuevo dato que necesitemos lo añadimos a la vista mediante un left join 
```sql
SELECT 
	Fcc.*, 
	F.SubTotalEuros as Total,
	F.TotalEuros as TotalIVA,
	F.BaseAnticiposConFactura,
	F.TotalAnticiposConFactura,
	FP.Descrip as FormadePago,
	SF.Descrip as SeriedeFactura,
	ED.Nombre as Creadopor,
    --Usaremos el capo de empresa como ejemplo.
	E.Nombre as Empresa
FROM 
	VDLG_Facturas_Cli_Cab Fcc
	LEFT JOIN vFacturas_Cli_Total_Anticipos  F ON Fcc.IdFactura =F.IdFactura
	LEFT JOIN FormasPago FP ON Fcc.FormaPago = FP.IdFormaPago
	LEFT JOIN Series_Facturacion SF on Fcc.SerieFactura = SF.SerieFactura
	LEFT JOIN Empleados_Datos ED on Fcc.IdEmpleado = ED.IdEmpleado
    --Añadimos hacemo sle left join para añadir la empresa 
	LEFT JOIN Empresa E on Fcc.IdEmpresa = E.IdEmpresa
GO
```
> Si quieres una descripción algo más detallada de todas las maneras de unir tablas [aquí](https://programacionymas.com/blog/como-funciona-inner-left-right-full-join) te dejo una guía

###### 3. Añadir campo a la aplicación de ERP

Ya solo quedaría ir a la palicación de ***Aministrador de ERP*** y declarar el nuevo campo.
![Añadir campo](/ERP_CRM_SQL\ERP\añadirCampoFiltro\img\Screenshot_2.png "añadir campo")
> La primera columna hace referencia al dato de la BBDD **Se tiene que llamar igual que en la BBDD** y la segunda columna será como se verá en la aplicación así que puedes llamaro como quieras. 