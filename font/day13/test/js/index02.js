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

         if(Item_className == "0" ) Item_className="IT1";
         else if (Item_className == "1") Item_className = "IT2";
         else if (Item_className == "2") Item_className = "IT3";



         let idMax = 0;
         data.forEach(element => {
             if(element.id > idMax){
                 idMax=element.id;
             }
         });

         var Item = {
            id:idMax+1,
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
    clear()
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
    <th scope="row"></th>
    <th>${data[i].id}  </th> 
    <th>${data[i].name}</th>
    <th>${data[i].class}</th>
    <th>${data[i].faculty}</th>
    <th>${data[i].address}</th>
    <th>${data[i].phone}</th>
    <th>${data[i].email}</th>
    
    <td   >
        <button type="button" class="btn-show btn btn-outline-primary">
            <i class="bi bi-eye"></i>
            Details
        </button>
        <button type="button" class="btn btn-outline-info"
            style="margin:0 0.5rem 0 0.5rem;"   onclick="editItem(${data[i].id})" >
            <i class="bi bi-arrow-repeat"></i>
            Update
        </button>
        <button type="button" class="btn btn-outline-danger "  data-bs-toggle="modal"
            data-bs-target="#exampleModal" onclick="deleteItem(${data[i].id})"  >
            <i class="bi bi-trash3"></i>
            Delete
        </button>
    </td>
</tr>`



}

document.getElementById("render").innerHTML = table;//${data[i].id}

$(".student-details").removeClass("student-details-show");
}

function clear(){
    document.getElementById("Name").value="";
    document.getElementById("DateBirth").value="";
    document.getElementById("Gender").value="";
    document.getElementById("PhoneNumber").value="";
    document.getElementById("Email").value="";
    document.getElementById("Address").value="";
    document.getElementById("Faculty").value="";
    document.getElementById("Class").value=""; 

}

function deleteItem(x){
    for(let i = 0;i<data.length;i++){
        if(data[i].id ==x){
            data.splice(i,1)
            render()
        }
    }
}

function editItem(x){
    for(let i = 0;i<data.length;i++){
        if(data[i].id==x ){
            document.getElementById("Name").value= data[i].name ;
            document.getElementById("DateBirth").value=data[i].gender;
            document.getElementById("Gender").value=data[i].phone;
            document.getElementById("PhoneNumber").value=data[i];
            document.getElementById("Email").value=data[i].email;
            document.getElementById("Address").value=data[i].address;
            document.getElementById("Faculty").value=data[i].faculty;
            document.getElementById("Class").value=data[i].class;
        }
    }
}



$(".add-new").click(function(){
    $(".student-details").addClass("student-details-show");
    
});
$(".btn-cancel").click(function(){
    $(".student-details").removeClass("student-details-show");
});


