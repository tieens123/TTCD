var data=[]

function handleClickAdd(){
    
         Item_fullName = document.getElementById("Name").value;
         Item_dateBirth = document.getElementById("DateBirth").value;
         Item_gender = document.getElementById("Gender").value;
         Item_phoneNunber = document.getElementById("PhoneNumber").value;
         Item_email = document.getElementById("Email").value;
         Item_address = document.getElementById("Address").value;
         Item_faculty = document.getElementById("Faculty").value;
        // objectInfo.className = document.getElementById("Class").value;
         Item_className = document.getElementById("Class").value; 

         var Item = {
            // id: "",
            name: Item_fullName,
            date:Item_dateBirth,  
            gender:Item_gender,
            phone:Item_phoneNunber,
            email:Item_email,
            address:Item_address,
            faculty:Item_faculty,
            class:Item_className,
        
        }

    data.push(Item)
    render()
}




function render(){
    table = `<tr class="bg-secondary text-light">
    <th scope="col">#</th>
    <th scope="col" class="text-nowrap">ID</th>
    <th scope="col" class="text-nowrap">Full Name</th>
    <th scope="col" class="text-nowrap">Class</th>
    <th scope="col" class="text-nowrap">Faculty Name</th>
    <th scope="col" class="text-nowrap">Address</th>
    <th scope="col" class="text-nowrap">Phone Number</th>
    <th scope="col" class="text-nowrap"> Email</th>
    <th scope="col" class="text-center">Action</th>
</tr>`
for(let i=0;i<data.length;i++){
    table += `<tr class="align-middle">
    <th scope="row">2</th>
    <th>  </th> 
    <th>${data[i].name}</th>
    <th>${data[i].class}</th>
    <th>${data[i].faculty}</th>
    <th>${data[i].address}</th>
    <th>${data[i].phone}</th>
    <th>${data[i].email}</th>
    
    <td class="">
        <button type="button" class="btn-show btn btn-outline-primary">
            <i class="bi bi-eye"></i>
            Details
        </button>
        <button type="button" class="btn btn-outline-info"
            style="margin:0 0.5rem 0 0.5rem;">
            <i class="bi bi-arrow-repeat"></i>
            Update
        </button>
        <button type="button" class="btn btn-outline-danger" data-bs-toggle="modal"
            data-bs-target="#exampleModal">
            <i class="bi bi-trash3"></i>
            Delete
        </button>
    </td>
</tr>`
}

document.getElementById("render").innerHTML = table;

}