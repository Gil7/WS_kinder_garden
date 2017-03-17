Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports DatosTableAdapters
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class Service
     Inherits System.Web.Services.WebService
    'Students CRUD+'
    <WebMethod()> _
    Public Function WS_get_all_students() As Datos
        Dim tblStudents As New estudianteTableAdapter
        Dim allRegisters As New Datos
        tblStudents.get_all_students(allRegisters.estudiante)
        Return allRegisters
    End Function
    <WebMethod()> _
    Public Function WS_create_student(matricula As String, nombre As String, ap As String, am As String, fecha_ingreso As String, fecha_baja As String) As String
        Dim tblStudent As New estudianteTableAdapter
        tblStudent.create_new_student(matricula, nombre, ap, am, fecha_baja, fecha_ingreso)
        Return "success"
    End Function
    <WebMethod()> _
    Public Function WS_find_student(matricula As String) As Datos
        Dim tblStudent As New estudianteTableAdapter
        Dim allRegisters As New Datos
        tblStudent.find_student(allRegisters.estudiante, matricula)
        Return allRegisters
    End Function
    <WebMethod()> _
    Public Function WS_update_student(matricula As String, nombre As String, ap As String, am As String, fecha_ingreso As String, fecha_baja As String) As String
        Dim tblStudent As New estudianteTableAdapter
        tblStudent.update_student(nombre, ap, am, fecha_ingreso, fecha_baja, matricula) 'the last field(matricula) is the constraint WHERE on the query
        Return "success"
    End Function

    <WebMethod()> _
    Public Function WS_delete_student(matricula As String) As String
        Dim tblStudent As New estudianteTableAdapter
        tblStudent.delete_student(matricula)
        Return "success"
    End Function
    'tutors'
    <WebMethod()> _
    Public Function WS_get_all_tutors() As Datos
        Dim tblTutor As New tutorTableAdapter
        Dim allRegisters As New Datos
        tblTutor.get_all_tutors(allRegisters.tutor)
        Return allRegisters
    End Function
    <WebMethod()> _
    Public Function WS_find_tutor(dni As String) As Datos
        Dim tblTutor As New tutorTableAdapter
        Dim Register As New Datos
        tblTutor.find_tutor(Register.tutor, dni)
        Return Register
    End Function
    <WebMethod()> _
    Public Function WS_update_tutor(dni As String, nombre As String, ap As String, am As String, direccion As String, parentesco As String, tutorado As String) As Boolean
        Dim tblTutor As New tutorTableAdapter
        tblTutor.update_tutor(nombre, ap, am, direccion, parentesco, tutorado, dni)
        Return True
    End Function
    <WebMethod()> _
    Public Function WS_delete_tutor(dni As String) As String
        Dim tblTutor As New tutorTableAdapter
        tblTutor.delete_tutor(dni)
        Return "success"
    End Function
    <WebMethod()> _
    Public Function WS_create_tutor(dni As String, nombre As String, ap As String, am As String, direccion As String, parentesco As String, tutorado As String) As String
        Dim tblTutor As New tutorTableAdapter
        tblTutor.create_tutor(dni, nombre, ap, am, direccion, parentesco, tutorado)
        Return "success"
    End Function

    'Phone'
    <WebMethod()> _
    Public Function WS_get_all_phones() As Datos
        Dim tblPhones As New telefonoTableAdapter
        Dim allRegisters As New Datos
        tblPhones.get_all_phones(allRegisters.telefono)
        Return allRegisters
    End Function

    <WebMethod()> _
    Public Function WS_create_phone(numero As String, dni As String) As String
        Dim tblPhone As New telefonoTableAdapter
        tblPhone.create_phone(numero, dni)
        Return "success"
    End Function
    <WebMethod()> _
    Public Function WS_update_phone(numero As String, dni As String, id As Integer) As String
        Dim tblPhone As New telefonoTableAdapter
        tblPhone.update_phone(numero, dni, id)

        Return "success"
    End Function
    <WebMethod()> _
    Public Function WS_find_phone(id As Integer) As Datos
        Dim tblPhone As New telefonoTableAdapter
        Dim Register As New Datos
        tblPhone.find_phone(Register.telefono, id)
        Return Register
    End Function
    <WebMethod()> _
    Public Function WS_delete_phone(id As Integer) As String
        Dim tblPhone As New telefonoTableAdapter
        tblPhone.delete_phone(id)
        Return "success"
    End Function
   'Accounts'
    <WebMethod()> _
    Public Function WS_get_all_accounts() As Datos
        Dim tblAccounts As New cuentaTableAdapter
        Dim allRegisters As New Datos
        tblAccounts.get_all_accounts(allRegisters.cuenta)
        Return allRegisters
    End Function
    <WebMethod()> _
    Public Function WS_create_account(numero As String, dni As String) As String
        Dim tblAccount As New cuentaTableAdapter
        tblAccount.create_account(numero, dni)
        Return "success"
    End Function
    <WebMethod()> _
    Public Function WS_find_accout(id As Integer) As Datos
        Dim tblAccount As New cuentaTableAdapter
        Dim Register As New Datos
        tblAccount.find_account(Register.cuenta, id)
        Return Register
    End Function
    <WebMethod()> _
    Public Function WS_update_account(numero As String, dni As String, id As Integer) As String
        Dim tblAccount As New cuentaTableAdapter
        tblAccount.update_account(numero, dni, id)
        Return "success"
    End Function
    <WebMethod()> _
    Public Function WS_delete_account(id As Integer) As String
        Dim tblAccount As New cuentaTableAdapter
        tblAccount.delete_account(id)
        Return "success"
    End Function
    'Charges'
    <WebMethod()> _
    Public Function WS_get_all_charges() As Datos
        Dim tblCharges As New cargoTableAdapter
        Dim allRegisters As New Datos
        tblCharges.get_all_charges(allRegisters.cargo)
        Return allRegisters
    End Function

    <WebMethod()> _
    Public Function WS_create_charge(total As Double, dni As String, matricula As String, cuenta As String, fecha As String) As String
        Dim tblCharge As New cargoTableAdapter
        tblCharge.create_charge(total, dni, matricula, cuenta, fecha)
        Return "Success"
    End Function
    <WebMethod()> _
    Public Function Ws_update_charge(total As Double, dni As String, matricula As String, cuenta As String, fecha As String, id As Integer) As String
        Dim tblCharge As New cargoTableAdapter
        tblCharge.update_charge(total, dni, matricula, cuenta, fecha, id)
        Return "success"
    End Function
    <WebMethod()> _
    Public Function WS_find_charge(id As Integer) As Datos
        Dim tblCharge As New cargoTableAdapter
        Dim Register As New Datos
        tblCharge.find_charge(Register.cargo, id)
        Return Register
    End Function
    <WebMethod()> _
    Public Function WS_delete_charge(id As Integer) As String
        Dim tblCharge As New cargoTableAdapter
        tblCharge.delete_charge(id)
        Return "success"
    End Function
    'Menus'

    <WebMethod()> _
    Public Function WS_get_all_menus() As Datos
        Dim tblMenus As New menuTableAdapter
        Dim allRegisters As New Datos
        tblMenus.get_all_menus(allRegisters.menu)
        Return allRegisters
    End Function

    <WebMethod()> _
    Public Function WS_create_menu(nombre As String, precio As Double) As Boolean
        Dim tblMenus As New menuTableAdapter
        tblMenus.create_menu(nombre, precio)
        Return True
    End Function
    <WebMethod()> _
    Public Function WS_find_menu(id As Integer) As Datos
        Dim tblMenu As New menuTableAdapter
        Dim Register As New Datos
        tblMenu.find_menu(Register.menu, id)
        Return Register
    End Function
    <WebMethod()> _
    Public Function WS_update_menu(nombre As String, precio As Double, id As Integer) As String
        Dim tblMenu As New menuTableAdapter
        tblMenu.update_menu(nombre, precio, id)
        Return "success"
    End Function
    <WebMethod()> _
    Public Function WS_delete_menu(id As Integer) As String
        Dim tblMenu As New menuTableAdapter
        tblMenu.delete_menu(id)
        Return "success"
    End Function
    'Saucers'
    <WebMethod()> _
    Public Function WS_get_all_saucers() As Datos
        Dim tblSaucers As New platoTableAdapter
        Dim allRegisters As New Datos
        tblSaucers.get_all_saucers(allRegisters.plato)
        Return allRegisters
    End Function
    <WebMethod()> _
    Public Function WS_create_saucer(nombre As String, menu_id As Integer) As String
        Dim tblSaucer As New platoTableAdapter
        tblSaucer.create_saucer(nombre, menu_id)
        Return "Success"
    End Function
    <WebMethod()> _
    Public Function WS_find_saucer(id As Integer) As Datos
        Dim tblSaucer As New platoTableAdapter
        Dim Register As New Datos
        tblSaucer.find_saucer(Register.plato, id)
        Return Register
    End Function
    <WebMethod()> _
    Public Function WS_update_saucer(nombre As String, menu_id As Integer, id As Integer) As String
        Dim tblSaucer As New platoTableAdapter
        tblSaucer.update_saucer(nombre, menu_id, id)
        Return "Success"
    End Function

    'Students consupmtions'
    <WebMethod()> _
    Public Function WS_get_all_consumptions() As Datos
        Dim tblStudent_Menu As New consumo_menu_estudianteTableAdapter
        Dim allRegisters As New Datos
        tblStudent_Menu.get_all_consumptions(allRegisters.consumo_menu_estudiante)
        Return allRegisters
    End Function
    <WebMethod()> _
    Public Function WS_create_consumption(matricula As String, menu_id As String, fecha As String) As String
        Dim tblConsumption As New consumo_menu_estudianteTableAdapter
        tblConsumption.create_consumption(matricula, menu_id, fecha)
        Return "success"
    End Function
    'Ingredients'
    <WebMethod()> _
    Public Function WS_get_all_ingredients() As Datos
        Dim tblIngredients As New ingredienteTableAdapter
        Dim allRegisters As New Datos
        tblIngredients.get_all_ingredients(allRegisters.ingrediente)
        Return allRegisters
    End Function
    <WebMethod()> _
    Public Function WS_create_ingredient(nombre As String) As String
        Dim tblIngredient As New ingredienteTableAdapter
        tblIngredient.create_ingredient(nombre)
        Return "success"
    End Function
    'Ingredients-Saucers[many-to-many table]'
    <WebMethod()> _
    Public Function WS_get_all_ingredients_saucers() As Datos
        Dim tblIngredientes_Saucers As New ingrediente_platoTableAdapter
        Dim allRegisters As New Datos
        tblIngredientes_Saucers.get_all_ingredients_saucers(allRegisters.ingrediente_plato)
        Return allRegisters
    End Function
    <WebMethod()> _
    Public Function WS_create_ingredient_saucer(plato_id As Integer, ingrediente As Integer) As String
        Dim tblIngredient_Saucer As New ingrediente_platoTableAdapter
        tblIngredient_Saucer.create_ingredient_saucer(plato_id, ingrediente)
        Return "success"
    End Function

    'Alergies [many-to-many table]'
    <WebMethod()> _
    Public Function WS_get_all_allergies() As Datos
        Dim tblAlergies As New ingrediente_alergico_estudianteTableAdapter
        Dim allRegisters As New Datos
        tblAlergies.get_all_alergies(allRegisters.ingrediente_alergico_estudiante)
        Return allRegisters
    End Function
    <WebMethod()> _
    Public Function WS_create_alergy(matricula As String, ingrediente As Integer) As String
        Dim tblAlergy As New ingrediente_alergico_estudianteTableAdapter
        tblAlergy.create_alergy(matricula, ingrediente)
        Return "success"

    End Function


End Class