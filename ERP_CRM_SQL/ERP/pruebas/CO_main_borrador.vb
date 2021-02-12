Sub Initialize()

    EstadoReparacion
    TipoParte
    CamposParte
    TipoAsistencia
    CamposAsistencia
    TipoVarios
    TipoInstalaciones
    Notas
    combotipo
    
    
    gForm.Controls("Pers_Combo_tipoparte").ActivarScripts = True
    
     'Se muestran y ocultan las pestañas al inicio
     gForm.Controls("TabDatos").item(0).visible = False
     gForm.Controls("TabDatos").item(1).visible = False
     gForm.Controls("TabDatos").item(2).visible = False
     gForm.Controls("TabDatos").item(3).visible = False
     gForm.Controls("TabDatos").item(4).visible = False
     gForm.Controls("TabDatos").item(5).visible = False
     gForm.Controls("TabDatos").item(204).selected = True
    
    

End Sub



Sub combotipo

  Set lControl = gForm.Controls.Add("AhoraOCX.ComboUsuario", "Pers_Combo_tipoparte", Gform.controls("FraDatos"))
  With lControl 
  
       .C1Nombre = "pers_tipo"
       .C1TipoDato = 8
       .C1Anchura = 2000
       .C2Nombre = "tipo"
       .C2TipoDato = 8
       .C2Anchura = 2000
       .CActiva = 2
       .NColumnas=2
       .Descripcion="select pers_tipo,pers_tipo as tipo from Conf_Partes_pers_tipo"
       .Formato = "Mayusculas y Minusculas"
      .TipoDato = "String"
       .ObjOrigen = "EObjeto"
       .ObjPOrigen = "pers_tipo"
       .visible = True
       .CaptionVisible = True
       .CaptionControl = "Tipo Parte"
       .CaptionWidth = 1800
       .Enabled = True
       .CaptionLink = True
       .move 6180,510,3500,300
       .AplicaEstilo 
       .TabStop=True
       .TabIndex = 25
       .necesario = True
  End With

End Sub

Sub CamposParte

  Set lControl = gForm.Controls.Add("AhoraOCX.ComboUsuario", "Pers_Combo_cargador", Gform.controls("Pers_Tipo_Parte"))
  With lControl 
  
       .C1Nombre = "pers_cargador"
       .C1TipoDato = 8
       .C1Anchura = 300
       .C2Nombre = "cargador"
       .C2TipoDato = 8
       .C2Anchura = 300
       .CActiva = 2
       .NColumnas=1
       .Descripcion="select pers_cargador,pers_cargador as cargador from Conf_Partes_pers_cargador"
       .Formato = "Mayusculas y Minusculas"
      .TipoDato = "String"
       .ObjOrigen = "EObjeto"
       .ObjPOrigen = "pers_cargador"
       .visible = True
       .CaptionVisible = True
       .CaptionControl = "Cargador:"
       .CaptionWidth = 1050
       .Enabled = True
       .CaptionLink = False
       .move 250,550,1700,300
       .AplicaEstilo 
       .TabStop=True
       .TabIndex = 25
       .necesario = True
  End With
  
  Set lControl = gForm.Controls.Add("AhoraOCX.ComboUsuario", "Pers_Combo_maletin", Gform.controls("Pers_Tipo_Parte"))
  With lControl 
  
       .C1Nombre = "pers_maletin"
       .C1TipoDato = 8
       .C1Anchura = 300
       .C2Nombre = "maletin"
       .C2TipoDato = 8
       .C2Anchura = 300
       .CActiva = 2
       .NColumnas=1
       .Descripcion="select pers_maletin,pers_maletin as maletin from Conf_Partes_pers_maletin"
       .Formato = "Mayusculas y Minusculas"
      .TipoDato = "String"
       .ObjOrigen = "EObjeto"
       .ObjPOrigen = "maletin"
       .visible = True
       .CaptionVisible = True
       .CaptionControl = "Maletín:"
       .CaptionWidth = 800
       .Enabled = True
       .CaptionLink = False
       .move 2100,550,1450,300
       .AplicaEstilo 
       .TabStop=True
       .TabIndex = 25
       .necesario = True
  End With
  
  Set lControl = gForm.Controls.Add("AhoraOCX.ComboUsuario", "Pers_Combo_bateria", Gform.controls("Pers_Tipo_Parte"))
  With lControl 
  
       .C1Nombre = "pers_bateria"
       .C1TipoDato = 8
       .C1Anchura = 400
       .C2Nombre = "bateria"
       .C2TipoDato = 8
       .C2Anchura = 400
       .CActiva = 2
       .NColumnas=1
       .Descripcion="select pers_bateria,pers_bateria as bateria from Conf_Partes_pers_bateria"
       .Formato = "Mayusculas y Minusculas"
      .TipoDato = "String"
       .ObjOrigen = "EObjeto"
       .ObjPOrigen = "pers_bateria"
       .visible = True
       .CaptionVisible = True
       .CaptionControl = "Batería:"
       .CaptionWidth = 700
       .Enabled = True
       .CaptionLink = False
       .move 3700,550,1450,300
       .AplicaEstilo 
       .TabStop=True
       .TabIndex = 25
       .necesario = True
  End With
  
  Set lControl = gForm.Controls.Add("AhoraOCX.TextoUsuario", "Pers_Text_extras", Gform.controls("Pers_Tipo_Parte"))
  With lControl 

       .Formato = "Mayusculas y Minusculas"
      .TipoDato = "String"
       .ObjOrigen = "EObjeto"
       .ObjPOrigen = "pers_extras"
       .visible = True
       .CaptionVisible = True
       .CaptionControl = "Extras:"
       .CaptionWidth = 1050
       .Enabled = True
       .CaptionLink = False
       .move 250,1250,2500,300
       .AplicaEstilo
       .TabStop=True
       .TabIndex = 25
       .necesario = True
  End With

  
  Set lControl = gForm.Controls.Add("AhoraOCX.TextoUsuario", "Pers_Text_marcamodelo", Gform.controls("Pers_Tipo_Parte"))
  With lControl 

       .Formato = "Mayusculas y Minusculas"
      .TipoDato = "String"
       .ObjOrigen = "EObjeto"
       .ObjPOrigen = "pers_marcamodelo"
       .visible = True
       .CaptionVisible = True
       .CaptionControl = "Marca:"
       .CaptionWidth = 1050
       .Enabled = True
       .CaptionLink = False
       .move 250,200,2500,300
       .AplicaEstilo
       .TabStop=True
       .TabIndex = 25
       .necesario = True
  End With

  Set lControl = gForm.Controls.Add("AhoraOCX.TextoUsuario", "Pers_Text_nserie", Gform.controls("Pers_Tipo_Parte"))
  With lControl 

       .Formato = "Mayusculas y Minusculas"
      .TipoDato = "String"
       .ObjOrigen = "EObjeto"
       .ObjPOrigen = "pers_nserie"
       .visible = True
       .CaptionVisible = True
       .CaptionControl = "Nº Serie:"
       .CaptionWidth = 750
       .Enabled = True
       .CaptionLink = False
       .move 2900,200,2500,300
       .AplicaEstilo
       .TabStop=True
       .TabIndex = 25
       .necesario = True
  End With
  
  Set lControl = gForm.Controls.Add("AhoraOCX.TextoUsuario", "Pers_Text_contrasena", Gform.controls("Pers_Tipo_Parte"))
  With lControl 

       .Formato = "Mayusculas y Minusculas"
      .TipoDato = "String"
       .ObjOrigen = "EObjeto"
       .ObjPOrigen = "pers_contrasena"
       .visible = True
       .CaptionVisible = True
       .CaptionControl = "Contraseña:"
       .CaptionWidth = 1050
       .Enabled = True
       .CaptionLink = False
       .move 250,900,2500,300
       .AplicaEstilo
       .TabStop=True
       .TabIndex = 25
       .necesario = True
  End With

     Set lControl = gForm.Controls.Add("AhoraOCX.TextoUsuario", "Pers_Text_fallo", Gform.controls("Pers_Tipo_Parte"))
     With lControl 
          .Formato = "Mayusculas y Minusculas"
     .TipoDato = "String"
          .ObjOrigen = "EObjeto"
          .ObjPOrigen = "pers_fallo"
          .visible = True
          .CaptionVisible = True
          .CaptionControl = "Fallo:"
          .CaptionWidth = 650
          .Enabled = True
          .CaptionLink = False
          .move 5600,200,9000,2000
          .AplicaEstilo
          .TabStop=True
          .TabIndex = 25
          .necesario = True
     End With

End Sub



Sub CamposAsistencia

  Set lControl = gForm.Controls.Add("AhoraOCX.ComboUsuario", "Pers_Combo_remsal", Gform.controls("Pers_Tipo_Asistencia"))
  With lControl 
  
       .C1Nombre = "pers_remsal"
       .C1TipoDato = 8
       .C1Anchura = 1000
       .C2Nombre = "remsal"
       .C2TipoDato = 8
       .C2Anchura = 1000
       .CActiva = 2
       .NColumnas=1
       .Descripcion="select pers_remsal,pers_remsal as remsal from Conf_Partes_pers_remsal"
       .Formato = "Mayusculas y Minusculas"
      .TipoDato = "String"
       .ObjOrigen = "EObjeto"
       .ObjPOrigen = "pers_remsal"
       .visible = True
       .CaptionVisible = True
       .CaptionControl = "Tipo de Incidencia:"
       .CaptionWidth = 1550
       .Enabled = True
       .CaptionLink = False
       .move 250,1250,2500,300
       .AplicaEstilo 
       .TabStop=True
       .TabIndex = 25
       .necesario = True
  End With
  
  Set lControl = gForm.Controls.Add("AhoraOCX.ComboUsuario", "Pers_Combo_nivel", Gform.controls("Pers_Tipo_Asistencia"))
  With lControl 
  
       .C1Nombre = "pers_nivel"
       .C1TipoDato = 8
       .C1Anchura = 1550
       .C2Nombre = "nivel"
       .C2TipoDato = 8
       .C2Anchura = 1550
       .CActiva = 2
       .NColumnas=1
       .Descripcion="select pers_nivel,pers_nivel as nivel from Conf_Partes_pers_nivel"
       .Formato = "Mayusculas y Minusculas"
      .TipoDato = "String"
       .ObjOrigen = "EObjeto"
       .ObjPOrigen = "pers_nivel"
       .visible = True
       .CaptionVisible = True
       .CaptionControl = "Nivel:"
       .CaptionWidth = 1550
       .Enabled = True
       .CaptionLink = False
       .move 250,550,2500,300
       .AplicaEstilo 
       .TabStop=True
       .TabIndex = 25
       .necesario = True
  End With
  
  Set lControl = gForm.Controls.Add("AhoraOCX.ComboUsuario", "Pers_Combo_dtpo", Gform.controls("Pers_Tipo_Asistencia"))
  With lControl 
  
       .C1Nombre = "pers_dpto"
       .C1TipoDato = 8
       .C1Anchura = 2000
       .C2Nombre = "dpto"
       .C2TipoDato = 8
       .C2Anchura = 2000
       .CActiva = 2
       .NColumnas=1
       .Descripcion="select pers_dpto,pers_dpto as dpto from Conf_Partes_pers_dpto"
       .Formato = "Mayusculas y Minusculas"
      .TipoDato = "String"
       .ObjOrigen = "EObjeto"
       .ObjPOrigen = "pers_dpto"
       .visible = True
       .CaptionVisible = True
       .CaptionControl = "Departamento:"
       .CaptionWidth = 1550
       .Enabled = True
       .CaptionLink = False
       .move 250,200,2800,300
       .AplicaEstilo 
       .TabStop=True
       .TabIndex = 25
       .necesario = True
  End With

  Set lControl = gForm.Controls.Add("AhoraOCX.ComboUsuario", "Pers_Combo_estado", Gform.controls("Pers_Tipo_Asistencia"))
  With lControl 
  
       .C1Nombre = "pers_estado"
       .C1TipoDato = 8
       .C1Anchura = 2000
       .C2Nombre = "estado"
       .C2TipoDato = 8
       .C2Anchura = 2000
       .CActiva = 2
       .NColumnas=1
       .Descripcion="select pers_estado,pers_estado as estado from Conf_Partes_pers_estado"
       .Formato = "Mayusculas y Minusculas"
      .TipoDato = "String"
       .ObjOrigen = "EObjeto"
       .ObjPOrigen = "pers_estado"
       .visible = True
       .CaptionVisible = True
       .CaptionControl = "Estado:"
       .CaptionWidth = 1550
       .Enabled = True
       .CaptionLink = False
       .move 250,1600,3500,300
       .AplicaEstilo 
       .TabStop=True
       .TabIndex = 25
       .necesario = True
  End With
  
    Set lControl = gForm.Controls.Add("AhoraOCX.ComboUsuario", "Pers_Combo_prioridad", Gform.controls("Pers_Tipo_Asistencia"))
  With lControl 
  
       .C1Nombre = "pers_prioridad"
       .C1TipoDato = 8
       .C1Anchura = 1550
       .C2Nombre = "prioridad"
       .C2TipoDato = 8
       .C2Anchura = 1550
       .CActiva = 2
       .NColumnas=1
       .Descripcion="select pers_prioridad,pers_prioridad as prioridad from Conf_Partes_pers_prioridad"
       .Formato = "Mayusculas y Minusculas"
      .TipoDato = "String"
       .ObjOrigen = "EObjeto"
       .ObjPOrigen = "pers_prioridad"
       .visible = True
       .CaptionVisible = True
       .CaptionControl = "Prioridad:"
       .CaptionWidth = 1550
       .Enabled = True
       .CaptionLink = False
       .move 250,900,2500,300
       .AplicaEstilo
       .TabStop=True
       .TabIndex = 25
       .necesario = True
  End With

     Set lControl = gForm.Controls.Add("AhoraOCX.TextoUsuario", "Pers_Text_fallo", Gform.controls("Pers_Tipo_Asistencia"))
     With lControl 
          .Formato = "Mayusculas y Minusculas"
     .TipoDato = "String"
          .ObjOrigen = "EObjeto"
          .ObjPOrigen = "pers_fallo"
          .visible = True
          .CaptionVisible = True
          .CaptionControl = "Fallo:"
          .CaptionWidth = 650
          .Enabled = True
          .CaptionLink = False
          .move 5600,200,7500,900
          .AplicaEstilo
          .TabStop=True
          .TabIndex = 25
          .necesario = True
     End With

End Sub

Sub TipoParte
      'Creamos la pestaña Taller en el control TabPrincipal
	Set lPnl = gForm.Controls.Add("Threed.SSPanel", "Pers_Tipo_Parte")

      lPnl.Visible=True 

      lPnl.autosize = 3 ' el contenido se ajusta al tamaño del panel

      
      lPnl.Object.Caption = ""

	gform.controls("TabDatos").InsertItem 201, "Taller", lPnl.Hwnd, 1

      'Creamos la pestaña Diagnostico en el control TabPrincipal

	Set lPnl2 = gForm.Controls.Add("Threed.SSPanel", "Pers_Diagnostico")

      lPnl2.Visible=True 

      lPnl2.autosize = 3 ' el contenido se ajusta al tamaño del panel

      lPnl2.Object.Caption = ""

	gform.controls("TabDatos").InsertItem 210, "Diagnóstico", lPnl2.Hwnd, 1
	
	'Añadimos el campo Diagnostico dentro de la pestaña Diagnostico. El campo diagnóstico es igual al trabajo realizado.
	
	Set lControl = gForm.Controls.Add("AhoraOCX.TextoMultilinea", "Pers_Text_trabreali", Gform.controls("Pers_Diagnostico"))
  With lControl 

       .Formato = "Mayusculas y Minusculas"
       .TipoDato = "String"
       .ObjOrigen = "EObjeto"
       .ObjPOrigen = "pers_trabreali"
       .visible = True
       .CaptionVisible = False
       .CaptionControl = "Trabajo Realizado:"
       .CaptionWidth = 750
       .Enabled = True
       .CaptionLink = False
       .move 3900,200,2500,300
       .AplicaEstilo
       .TabStop=True
       .TabIndex = 25
       .necesario = False
  End With
	
	'Creamos la pestaña Piezas Internas en el control TabPrincipal

	Set lPnl3 = gForm.Controls.Add("Threed.SSPanel", "Pers_piezas_internas")

     lPnl3.Visible=True 

     lPnl3.autosize = 3 ' el contenido se ajusta al tamaño del panel

    lPnl3.Object.Caption = ""

	gform.controls("TabDatos").InsertItem 211, "Piezas Internas", lPnl3.Hwnd, 1
	
	'Añadimos el campo Piezas Internas dentro de la pestaña Piezas Internas.
	
	Set lControl = gForm.Controls.Add("AhoraOCX.TextoMultilinea", "Pers_Text_Piezas", Gform.controls("Pers_piezas_internas"))
  With lControl 

       .Formato = "Mayusculas y Minusculas"
       .TipoDato = "String"
       .ObjOrigen = "EObjeto"
       .ObjPOrigen = "pers_piezas"
       .visible = True
       .CaptionVisible = False
       .CaptionControl = "Piezas Internas:"
       .CaptionWidth = 750
       .Enabled = True
       .CaptionLink = False
       .move 3900,200,2500,300
       .AplicaEstilo
       .TabStop=True
       .TabIndex = 25
       .necesario = False
  End With


End Sub

Sub TipoVarios

	Set lPnl = gForm.Controls.Add("Threed.SSPanel", "Pers_Tipo_Varios")

     lPnl.Visible=True 

     lPnl.autosize = 3 ' el contenido se ajusta al tamaño del panel

     'Creamos la pestaña en el control TabPrincipal
    lPnl.Object.Caption = ""

	gform.controls("TabDatos").InsertItem 202, "Varios", lPnl.Hwnd, 1
	
	Set lControl = gForm.Controls.Add("AhoraOCX.TextoMultilinea", "Pers_Text_varios", Gform.controls("Pers_Tipo_Varios"))
  With lControl 

       .Formato = "Mayusculas y Minusculas"
       .TipoDato = "String"
       .ObjOrigen = "EObjeto"
       .ObjPOrigen = "pers_varios"
       .visible = True
       .CaptionVisible = False
       .CaptionControl = "Varios:"
       .CaptionWidth = 750
       .Enabled = True
       .CaptionLink = False
       .move 3900,200,2500,300
       .AplicaEstilo
       .TabStop=True
       .TabIndex = 25
       .necesario = False
  End With


End Sub

Sub TipoInstalaciones

	Set lPnl = gForm.Controls.Add("Threed.SSPanel", "Pers_Tipo_Instalacioneslaciones")

     lPnl.Visible=True 

     lPnl.autosize = 3 ' el contenido se ajusta al tamaño del panel

     'Creamos la pestaña en el control TabPrincipal
    lPnl.Object.Caption = ""

	gform.controls("TabDatos").InsertItem 203, "Instalación", lPnl.Hwnd, 1


End Sub


Sub TipoAsistencia

	Set lPnl = gForm.Controls.Add("Threed.SSPanel", "Pers_Tipo_Asistencia")

     lPnl.Visible=True 

     lPnl.autosize = 3 ' el contenido se ajusta al tamaño del panel

     'Creamos la pestaña en el control TabPrincipal
    lPnl.Object.Caption = ""

	gform.controls("TabDatos").InsertItem 204, "Asistencia", lPnl.Hwnd, 1


End Sub

Sub Notas

	Set lPnl = gForm.Controls.Add("Threed.SSPanel", "Pers_Notas")

     lPnl.Visible=True 

     lPnl.autosize = 3 ' el contenido se ajusta al tamaño del panel

     'Creamos la pestaña en el control TabPrincipal
    lPnl.Object.Caption = ""

	gform.controls("TabDatos").InsertItem 205, "Notas", lPnl.Hwnd, 1
	
	Set lControl = gForm.Controls.Add("AhoraOCX.TextoMultilinea", "Pers_Text_notas", Gform.controls("Pers_Notas"))
  With lControl 

       .Formato = "Mayusculas y Minusculas"
       .TipoDato = "String"
       .ObjOrigen = "EObjeto"
       .ObjPOrigen = "pers_notas"
       .visible = True
       .CaptionVisible = False
       .CaptionControl = "Notas:"
       .CaptionWidth = 750
       .Enabled = True
       .CaptionLink = False
       .move 3900,200,2500,300
       .AplicaEstilo
       .TabStop=True
       .TabIndex = 25
       .necesario = False
  End With
	

End Sub

Sub EstadoReparacion

     Set lPnl = gForm.Controls.Add("Threed.SSPanel", "Pers_estados_reparacion")

     lPnl.Visible=True 

     lPnl.autosize = 3 ' el contenido se ajusta al tamaño del panel

     'Creamos la pestaña en el control TabPrincipal

     gForm.TabDatos.InsertItem 200, "Histórico Estados", lPnl.Hwnd, 1

     Set lGrid = gForm.Controls.Add("AhoraOCX.cntGridUsuario", "grdPers_estados",lPnl)

     lGrid.Visible=True
     lGrid.AplicaEstilo
 

     'En vez de utilizar un FROM "TABLA" vamos a construir la consulta dinámicamente. Pero para ello necesitamos poner un alias en el grid

     lsql = "(select p.idlinea,p.idestado,per.Descrip,p.fechaestado,p.usuario, p.iddoc from pers_partes_estados_hist p left Join PartesEstadoReparacion per On per.IdEstado=p.idestado"& _
             " where idparte = " & gForm.Controls("EObjeto").ObjGlobal.Propiedades("IdParte")&") a"



     With lGrid ' NO_TRADUCIR_TAG

             .Agregar = False
             .Editar = False
             .Eliminar = False
             .CargaObjetos = False
             .EditarPorObjeto = False
             .alias = "a"

             .AgregaColumna "idlinea", 400, "Nº", True

             .AgregaColumna "idestado", 800, "id Estado",False

             .AgregaColumna "Descrip", 4000, "Estado",False
             .AgregaColumna "fechaestado", 2000, "Fecha",False
             .AgregaColumna "usuario", 800, "usuario",False


 
             .From = lsql

             .Where = ""

             '.ColumnaEscalada = "Cliente"

             .OrdenMultiple = "fechaestado"

             .RefrescaSinLoad = True 

             .Refresca = True

     End With
End Sub

Sub CargaObjeto

      lsql = "(select p.idlinea,p.idestado,per.Descrip,p.fechaestado,p.usuario, p.iddoc from pers_partes_estados_hist p left Join PartesEstadoReparacion per On per.IdEstado=p.idestado"& _
             " where idparte = " & gForm.Controls("EObjeto").ObjGlobal.Propiedades("IdParte")&") a"


     gform.controls ("grdPers_estados").from = lsql

     gform.controls ("grdPers_estados").refrescar
     
     ' Refrescamos visibilidad de las pestañas en funcion del tipo de parte
     CargaPestanas
	 
End Sub




Sub Combo_AfterUpdate(aCombo)
     If acombo.name = "Pers_Combo_tipoparte" Then 

          CargaPestanas

     End If
End Sub

Sub CargaPestanas
    If gForm.Controls("Pers_Combo_tipoparte").Value = "Instalaciones" Then 
          gForm.Controls("TabDatos").item(201).visible      = False
          gForm.Controls("TabDatos").item(202).visible      = False
          gForm.Controls("TabDatos").item(203).visible      = True
          gForm.Controls("TabDatos").item(204).visible      = False
          gForm.Controls("TabDatos").item(205).visible      = True
          gForm.Controls("TabDatos").item(203).selected     = True
          gForm.Controls("TabDatos").item(210).visible      = False
          gForm.Controls("TabDatos").item(211).visible      = False
    End If
  

     If gForm.Controls("Pers_Combo_tipoparte").Value = "Taller" Then 
          gForm.Controls("TabDatos").item(201).visible      = True
          gForm.Controls("TabDatos").item(202).visible      = False
          gForm.Controls("TabDatos").item(203).visible      = False
          gForm.Controls("TabDatos").item(204).visible      = False
          gForm.Controls("TabDatos").item(201).selected     = True
          gForm.Controls("TabDatos").item(210).visible      = True
          gForm.Controls("TabDatos").item(211).visible      = True
          'gForm.Controls("TabDatos").item(200).move 15
     End If
    
     If gForm.Controls("Pers_Combo_tipoparte").Value = "Varios" Then    
          gForm.Controls("TabDatos").item(201).visible      = False
          gForm.Controls("TabDatos").item(202).visible      = True
          gForm.Controls("TabDatos").item(203).visible      = False
          gForm.Controls("TabDatos").item(204).visible      = False
          gForm.Controls("TabDatos").item(205).visible      = False
          gForm.Controls("TabDatos").item(210).visible      = False
          gForm.Controls("TabDatos").item(211).visible      = False
          gForm.Controls("TabDatos").item(202).selected     = True
     End If
    
     If gForm.Controls("Pers_Combo_tipoparte").Value = "Asistencia" Then 
          gForm.Controls("TabDatos").item(201).visible      = False
          gForm.Controls("TabDatos").item(202).visible      = False
          gForm.Controls("TabDatos").item(203).visible      = False
          gForm.Controls("TabDatos").item(204).visible      = True
          gForm.Controls("TabDatos").item(205).visible      = True
          gForm.Controls("TabDatos").item(210).visible      = True
          gForm.Controls("TabDatos").item(211).visible      = False
          gForm.Controls("TabDatos").item(204).selected     = True
     End If
     
     If gForm.Controls("Pers_Combo_tipoparte").Value = "Borrame" Then 'Controlador copiado de Asistencia
'          gForm.Controls("TabDatos").item(201).visible      = False
'          gForm.Controls("TabDatos").item(202).visible      = False
'          gForm.Controls("TabDatos").item(203).visible      = False
'          gForm.Controls("TabDatos").item(204).visible      = False
'          gForm.Controls("TabDatos").item(205).visible      = False
'          gForm.Controls("TabDatos").item(210).visible      = False
'          gForm.Controls("TabDatos").item(211).visible      = False
'          gForm.Controls("TabDatos").item(204).selected     = False
     End If
End Sub

Sub Show()

    ' Refrescamos visibilidad de las pestañas en funcion del tipo de parte
     CargaPestanas

End Sub

