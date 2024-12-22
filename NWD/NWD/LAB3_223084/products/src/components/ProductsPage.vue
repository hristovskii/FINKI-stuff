<template>
  <div class="text-right"><button class="btn btn-primary" data-toggle="modal" data-target="#cartModal">Cart ({{cartItems.length}})</button></div>

  <!-- Modal -->
  <div class="modal fade" id="cartModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
    <div class="modal-dialog" role="document">
      <div class="modal-content">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal" aria-label="Close">          <span aria-hidden="true">&times;</span></button>
          <h4 class="modal-title" id="myModalLabel">Cart</h4>
        </div>
        <div class="modal-body">
          <shopping-cart inline-template :items="cartItems">
            <div>
              <table class="table table-cart">
                <tr v-for="(item, index) in cartItems">
                  <td>{{item.title}}</td>
                  <td style="width:120px">QTY:
                    <input v-model="item.qty" class="form-control input-qty" type="number">
                  </td>
                  <td class="text-right">${{item.price | formatCurrency}}</td>
                  <td>
                    <button @click="removeItem(index)"><span> Remove </span></button>
                  </td>
                </tr>
                <tr v-show="items.length === 0">
                  <td colspan="4" class="text-center">Cart is empty</td>
                </tr>
                <tr v-show="items.length > 0">
                  <td></td>
                  <td class="text-right">Cart Total</td>
                  <td class="text-right">${{Total | formatCurrency}}</td>
                  <td></td>
                </tr>
              </table>
            </div>
          </shopping-cart>
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
        </div>
      </div>
    </div>
  </div>

  <div class="container">
    <div class="row">
      <div class="col-xs-3 text-center" v-for="(item, index) in items">
        <img class="img-responsive" :src="item.image" width="150" alt="">
        <h5>{{ item.title }}</h5>
        <h6>${{ item.price | formatCurrency }}</h6>
        <p class="text-center"><input v-model="item.qty" type="number" class="form-control" placeholder="Qty" min="1"/></p>

        <button class="btn btn-sm btn-primary" @click="addItemToCart(item)">Add to Cart</button>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "ProductsPage",
  data() {
    return {
      Total: 0,
      formatCurrency: "",

      cartItems: [],

      items: [
        {id: 1,title: 'LenovoThinkpad x280', price: 1000.00, qty: 1, image: './img/ThinkPad_x280.png'},
        {id: 2,title: 'Apple Macbook Pro',price: 2500.00, qty: 1,image: './img/MacBook-Pro.png'},
        {id: 3,title: 'Amazon Kindle Ebook',price: 150.00,qty: 1,image: './img/Amazon_Kindle.png'},
        {id: 4,title: 'USB-C to HDMI cable',price: 10, qty: 1, image: './img/usbC_to_hdmi.jpg'},
      ],
    }
  },
  methods: {
    removeItem(index) {
      this.cartItems.splice(index, 1)
    },
    addItemToCart(item) {
      let wantedItem = {}
      let found = false;
      for (let cartItem of this.cartItems) {
        if (cartItem.id === item.id) {
          wantedItem = cartItem
          wantedItem.qty += item.qty
          found = true;
          break
        }
      }
      if (!found) {
        wantedItem = {
          id: item.id,
          title: item.title,
          price: item.price,
          qty: item.qty
        }
        this.cartItems.push(wantedItem)
      }
      item.qty = 1;
    },
  },
  computed: {
    Total() {
      let sum=0
      for (let cartItem of this.cartItems) {
        sum+= (cartItem.price * cartItem.qty)
      }
      return sum
    }
  }
}
</script>
