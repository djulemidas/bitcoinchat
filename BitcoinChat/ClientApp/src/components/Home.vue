<template>
 <h3 id="tableLabel">Bitcoin prices</h3>

  <p>This component demonstrates fetching data from the server.</p>

  <p v-if="!pricesPerDate"><em>Loading...</em></p>

  <table class='table table-striped' aria-labelledby="tableLabel" v-if="pricesPerDate">
    <thead>
      <tr>
        <th>Date</th>
        <th>Price</th>
      </tr>
    </thead>
    <tbody>
      <tr v-for="pricePerDate of pricesPerDate" v-bind:key="pricePerDate">
        <td>{{ pricePerDate.date }}</td>
        <td>{{ pricePerDate.price }}</td>
      </tr>
    </tbody>
  </table>
</template>

<script>

import axios from 'axios'
export default {
    name: "FetchData",
    data() {
        return {
            pricesPerDate: []
        }
    },
    methods: {
        getBitcoinPrices() {
            axios.get('/api/bitcoinprices/range')
                .then((response) => {
                    this.pricesPerDate =  response.data.pricesPerDate;
                })
                .catch(function (error) {
                    alert(error);
                });
        }
    },
    mounted() {
        this.getBitcoinPrices();
    }
}

</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  h3 {
    margin: 40px 0 0;
  }

  ul {
    list-style-type: none;
    padding: 0;
  }

  li {
    display: inline-block;
    margin: 0 10px;
  }

  a {
    color: #42b983;
  }
</style>