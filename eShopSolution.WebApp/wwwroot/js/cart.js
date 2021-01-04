var CartController = function () {
    this.initialize = function () {
        loadData();

        registerEvents();
    }

    function registerEvents() {
        $('body').on('click', '.btn-plus', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            const quantity = parseInt($('#txt_quantity_' + id).val()) + 1;
            UpdateCart(id, quantity);
        });

        $('body').on('click', '.btn-minus', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            const quantity = parseInt($('#txt_quantity_' + id).val()) - 1;
            UpdateCart(id, quantity);
        });

        $('body').on('click', '.btn-remove', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            UpdateCart(id, 0);
        });
    }

    function UpdateCart(id, quantity) {
        const culture = $('#hidCulture').val();
        $.ajax({
            type: "POST",
            url: "/" + culture + '/Cart/UpdateCart',
            data: {
                id: id,
                quantity: quantity,
            },
            success: function (res) {
                $('#lbl_number_of_items_header').text(res.length);
                loadData();
            }
        });
    }

    function loadData() {
        const culture = $('#hidCulture').val();
        $.ajax({
            type: "GET",
            url: "/" + culture + '/Cart/GetListItems',
            success: function (res) {
                
                var html = '';
                var noneCart = '';
                var total = 0;
                if (res.length === 0) {
                    $('#tbl_cart').hide();
                    noneCart += "<h3>Chưa có sản phẩm nào trong giỏ hàng</h3>"
                }
                $.each(res, function (i, item) {
                    var amount = item.price * item.quantity;
                     html += "<tr>"
                        + "<td> <img width=\"60\" src=\"" + $('#hidBaseAddress').val() + item.image + "\" alt=\"\" /></td>"
                        + "<td>" + item.description + "</td>"
                        + "<td>"
                         + "<div class=\"input-append\">"
                         + "<input class=\"span1\" style=\"max-width:34px\" placeholder=\"1\" id=\"txt_quantity_" + item.productId + "\" value=\"" + item.quantity + "\" size=\"16\" type=\"text\">"
                        + "<button class=\"btn btn-minus\" data-id=\"" + item.productId + "\" type=\"button\"><i class=\"icon-minus\"></i></button>"
                         + "<button class=\"btn btn-plus\" data-id=\"" + item.productId + "\" type=\"button\"><i class=\"icon-plus\"></i></button >"
                         + "<button class=\"btn btn-danger btn-remove\" type=\"button\" data-id=\"" + item.productId + "\"><i class=\"icon-remove icon-white\"></i></button></div>"
                        + "</td>"
                        + "<td>" + numbarWithCommas(item.price) + "</td>"
                        + "<td>" + numbarWithCommas(amount) + "</td>"
                        + "</tr>";
                    total += amount;
                });
                $('#cart_body').html(html);
                $('#none-cart').html(noneCart);
                $('#lbl_number_of_items').text(res.length);
                $('#lbl_total').text(numbarWithCommas(total));
            },

        });
    }
}