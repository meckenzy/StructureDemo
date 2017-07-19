Public Class Form1
    Public Sub DisplayCustomer(customer As Customer)
        'Display the customer details on the form
        txtName.Text = customer.Name
        txtFirstName.Text = customer.FirstName
        txtLastName.Text = customer.LastName
        txtEmail.Text = customer.Email
    End Sub

    Private Sub btnListcustomer_Click(sender As Object, e As EventArgs) Handles btnListcustomer.Click
        'Create a new customer
        Dim objCustomer As Customer
        objCustomer.FirstNAme = "Jordynn"
        objCustomer.LastName = "Skinner"
        objCustomer.Email = "jskinner@somecompany.com"

        'Display the customer
        DisplayCustomer(objCustomer)
    End Sub
End Class
