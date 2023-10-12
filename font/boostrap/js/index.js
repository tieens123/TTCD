$(document).ready(function(){
    var listProduct = [];

    listProduct.push(addProduct(["sp1.png","sp2.png","sp3.png","sp4.png","sp5.png"],"BÀN UỐNG NƯỚC",5,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct(["sp2.png","sp5.png","sp6.png"],"KỆ TV",5,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct(["sp3.png","sp2.png","sp3.png"],"BÀN UỐNG NƯỚC 2" ,3,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct(["sp4.png","sp2.png","sp3.png"],"BÀN UỐNG NƯỚC",4,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct(["sp5.png","sp2.png","sp3.png"],"BÀN UỐNG NƯỚC",4,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct(["sp6.png","sp2.png","sp3.png"],"BÀN UỐNG NƯỚC",1,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct(["sp7.png","sp2.png","sp3.png"],"BÀN UỐNG NƯỚC",4,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct(["sp8.png","sp2.png","sp3.png"],"BÀN UỐNG NƯỚC",3,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct(["sp9.png","sp2.png","sp3.png"],"BÀN UỐNG NƯỚC",2,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct(["sp10.png","sp2.png","sp3.png"],"BÀN UỐNG NƯỚC",4,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct(["sp11.png","sp2.png","sp3.png"],"BÀN UỐNG NƯỚC",5,"(size vừa,nâu đậm)","8.999.999"));
    listProduct.push(addProduct(["sp12.png","sp2.png","sp3.png"],"BÀN UỐNG NƯỚC",1,"(size vừa,nâu đậm)","8.999.999"));

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
        //copy array obj

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
            <div class="col-md-3 col-sm-6  mb-3 product-item "   data-bs-toggle="modal" data-bs-target="#exampleModal" data-id = ${i}>
            <div class="card">
                <img src="../images/xemtatca_sanpham/${listProduct[i].img[0]}" alt="" class="card-img-top">
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

        $(".product-item").click(function(){
            const id = $(this).data("id");
            //lấy thông tin
            var htmlStar = "Đánh giá: ";
            for(let j=0;j<listProduct[id].rate;j++){
                htmlStar+=`<i class="fa-solid fa-star text-gold"></i>`;
            }
            $("#exampleModal .title").text(listProduct[id].name);

            $("#exampleModal .rate").html(htmlStar);
            $("#exampleModal .desc").text("Mô tả" +listProduct[id].desc);
            $("#exampleModal .price").text("Giá" +listProduct[id].price);

            //lấy hình ảnh
            $(".product-slide .slider-for").html("");
            $(".product-slide .slider-nav").html("");

            var htmlProductSlide = "";
            var htmlProductSlide_Bottom = "";
            for (let i = 0; i<listProduct[id].img.length;i++){
                htmlProductSlide +=`
                <div class="img-box">
                    <img src="../images/xemtatca_sanpham/${listProduct[id].img[i]}" alt="" class="w-100 object-fit-cover" style="height: 25rem;">
                </div>
                `;

                htmlProductSlide_Bottom +=`
                <div class="img-box me-2">
                    <img src="../images/xemtatca_sanpham/${listProduct[id].img[i]}" alt="" class="w-100 ;">
                </div>
                `;

            }
            $(".product-slide .slider-for").html(htmlProductSlide);
            $(".product-slide .slider-nav").html(htmlProductSlide_Bottom);

            $('.slider-for').slick('refresh');
            $('.slider-nav').slick('refresh');


        });
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
