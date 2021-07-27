<template>
    <div class="hello">
        <img src="../assets/logo.png" />
        <p>
            Current price:
            {{currentPrice}}
        </p>
        <div class="small">
          <bitcoin-chart :chart-data="datacollection"></bitcoin-chart>
          <button @click="fillData()">Randomize</button>
        </div>
    </div>
</template>

<script>
import BitcoinChart from './BitcoinChart.js'

export default {
  components: {
      BitcoinChart
  },
  name: 'Home',
  data() {
    return {
        currentPrice: 0.0,
        prices: [],
        datacollection: null
    }
  },
  mounted () {
    this.fillData()
  },
  methods: {
    fillData () {
      this.datacollection = {
        labels: [this.getRandomInt(), this.getRandomInt()],
        datasets: [
          {
            label: 'Data One',
            backgroundColor: '#f87979',
            data: [this.getRandomInt(), this.getRandomInt()]
          }, {
            label: 'Data One',
            backgroundColor: '#f87979',
            data: [this.getRandomInt(), this.getRandomInt()]
          }
        ]
      }
    },
    getRandomInt () {
      return Math.floor(Math.random() * (50 - 5 + 1)) + 5
    }
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
