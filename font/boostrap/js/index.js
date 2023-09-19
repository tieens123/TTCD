$(document).ready(function(){
    var listProduct = [];

    listProduct.push(addProduct("sp1.png","BÀN UỐNG NƯỚC",5,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct("sp2.png","KỆ TV",5,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct("sp3.png","KỆ ĐỂ ĐỒ",3,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct("sp4.png","BÀN UỐNG NƯỚC",4,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct("sp5.png","BÀN UỐNG NƯỚC",4,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct("sp6.png","BÀN UỐNG NƯỚC",1,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct("sp7.png","BÀN UỐNG NƯỚC",4,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct("sp8.png","BÀN UỐNG NƯỚC",3,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct("sp9.png","BÀN UỐNG NƯỚC",2,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct("sp10.png","BÀN UỐNG NƯỚC",4,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct("sp11.png","BÀN UỐNG NƯỚC",5,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct("sp12.png","BÀN UỐNG NƯỚC",1,"(size vừa,nâu đậm)","8.999.999"));

    console.log(listProduct);
    renderListProduct(listProduct);
    
   

    $("#sortRate").click(function(){
        let newListProduct = listProduct.slice();
        newListProduct = newListProduct.sort(function(a,b){
            return a.rate - b.rate;
        });
        console.log(newListProduct);
        renderListProduct(newListProduct);
    });

    $("#sortName").click(function(){
        let newListProduct = listProduct.slice();
        newListProduct = newListProduct.sort(function(a,b){
            if(a.name<b.name)
            return -1;
            else if(a.name == b.name) 
            return 0;
            else return 1;

        });
        console.log(newListProduct);
        renderListProduct(newListProduct);
    });

    $("#sortDefault").click(function(){
        renderListProduct(listProduct);
    });
    
    function renderListProduct(listProduct){
       
        $(".list-products .products .row").html("");
        var htmlListProduct = "";
        for(let i =0;i<listProduct.length;i++ ){
            var htmlStar = "";
            for(let j=0;j<listProduct[i].rate;j++){
                htmlStar+=`<i class="fa-solid fa-star text-gold"></i>`;
            }
            htmlListProduct+=`
            <div class="col-md-3 col-sm-6  mb-3 "   data-bs-toggle="modal" data-bs-target="#exampleModal">
            <div class="card">
                <img src="../images/xemtatca_sanpham/${listProduct[i].img}" alt="" class="card-img-top">
                <div class="card-body py-2">
                    <h5 class="card-title text-center">${listProduct[i].name}</h5>
                    <span class="star text-center d-block">
                        ${htmlStar}

                    </span>
                    <span class="desc text-secondary d-block text-center">${listProduct[i].desc} </span>
                    <span class="price d-block text-center">${listProduct[i].price}</span>
                </div>
            </div>
        
        </div>`;
        }
        $(".list-products .products .row").html(htmlListProduct);
    }
    
    function addProduct(imgInput,nameInput,rateInput,descInput,priceInput){
        return{
            img: imgInput,
            name: nameInput,
            rate: rateInput,
            desc: descInput,
            price: priceInput,

        }
        
    }

     


})