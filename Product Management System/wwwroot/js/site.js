function deleteProduct(product_Id) {
    Swal.fire({
        title: "Are you sure?",
        text: "You want to delete this product!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            debugger
            $.ajax({
                url: 'Product/DeleteProduct',
                type: 'POST',
                data: { product_Id: product_Id },
                success: function (response) {
                    if(response === true) {
                        Swal.fire({
                            title: "Deleted!",
                            text: "Product has been deleted.",
                            icon: "success"
                        }).then(() => {
                            location.reload(); 
                        });
                    } else {
                        Swal.fire({
                            title: "Error!",
                            text: "Something went wrong.",
                            icon: "error"
                        });
                    }                
                },
                error: function (error) {
                    Swal.fire({
                        title: "Error!",
                        text: "Something went wrong.",
                        icon: "error"
                    });
                }
            });
        }
    });
}


$(document).ready(function () {
    tab_css();
    $('#productList').DataTable({
        language: {
            searchPlaceholder: "Search here"
        },
        "lengthMenu": [[5, 10, 20, 50, 100 - 1], [5, 10, 20, 50, 100, "All"]],
        "pageLength": 5
    });

});


function viewProductDetails(Id)
{
    window.location.href = `Shop/Details?Id=${Id}`;
}