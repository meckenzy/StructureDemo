Public Class Form1

    Private objCustomers As New CustomerCollection

    Public Sub CreateCustomer(firstName As String, lastName As String, email As String)

        'Declare a Customer object
        Dim objNewCustomer As Customer

        'Create the new customer
        objNewCustomer.FirstName = firstName
        objNewCustomer.LastName = lastName
        objNewCustomer.Email = email

        'Add the new customer to the list
        objCustomers.Add(objNewCustomer)

        'Add the new customer to the ListBox control
        lstCustomers.Items.Add(objNewCustomer)

    End Sub
    Public Sub DisplayCustomer(customer As Customer)
        'Display the customer details on the form
        txtName.Text = customer.Name
        txtFirstName.Text = customer.FirstName
        txtLastName.Text = customer.LastName
        txtEmail.Text = customer.Email
    End Sub

    Private Sub btnListcustomer_Click(sender As Object, e As EventArgs) Handles btnListcustomer.Click
        'Create a new customer

        'Dim objCustomer As Customer
        'objCustomer.FirstName = "Jordynn"
        'objCustomer.LastName = "Skinner"
        'objCustomer.Email = "jskinner@somecompany.com"

        CreateCustomer("Jordynn", "Skinner", "jskinner@hotmail.com")
        CreateCustomer("Serge", "Badio", "sbadio@hotmail.com")
        CreateCustomer("Alex", "Coors-Light", "acoorslight@hotmail.com")



        'Display the customer
        DisplayCustomer(objCustomers)
    End Sub

    Public ReadOnly Property SelectedCustomer() As Customer
        Get
            If lstCustomers.SelectedIndex <> -1 Then
                'Return the selected customer
                Return objCustomers(lstCustomers.SelectedIndex)
            End If
        End Get
    End Property

    Private Sub btnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomer.Click

        'If no customer is selected in the ListBox then.
        If lstCustomers.SelectedIndex = -1 Then

            'Display a message
            MessageBox.Show("You must select a customer to delete.",
                       "Structure Demo")

            'Exit this method
            Exit Sub

            'Promt the user to delete the slected customer
            If MessageBox.Show("Are you sure you want to delete " &
                SelectedCustomer.Name & " & ", "Structure Demo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) =
                DialogResult.Yes Then

                'Get the customer to deleted
                Dim objCustomerToDelete As Customer = SelectedCustomer

                'Remove the customer from the ArrayList
                objCustomers.Remove(objCustomerToDelete)

                'Remove the customer from the ListBox
                lstCustomers.Items.Remove(objCustomerToDelete)
            End If
        End If
    End Sub

    Private Sub lstCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustomers.SelectedIndexChanged
        'Display the customer details
        DisplayCustomer(SelectedCustomer)
    End Sub

    Private Sub btnLookup_Click(sender As Object, e As EventArgs) Handles btnLookup.Click
        'Declare a customer object and set it to the customer
        'with the email address to be found 
        Dim objFoundCustomer As Customer = objCustomers(txtEmail.Text)

        If Not IsNothing(objFoundCustomer.Email) Then
            'Display the customers name
            MessageBox.Show("The customers name is : " &
                            objFoundCustomer.Name, "Structure Demo")
        Else
            'Display an error
            MessageBox.Show("There is no customer with the e-mail
                address " & txtEmail.Text & " . ", "Structure Demo")
        End If
    End Sub
End Class
