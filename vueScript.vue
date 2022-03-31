<template>
    <div id="mainDiv">
        <input id="sum" type="number" min="1" max="4000" placeholder="Type a summ" v-model="credit" ><br>
        Select months: 
        <select nrid="months" name="" id="" v-model="months">
            <option value="1">1</option>
            <option value="2">2</option>
            <option value="3">3</option>
            <option value="4">4</option>
            <option value="5">5</option>
            <option value="6">6</option>
            <option value="7">7</option>
            <option value="8">8</option>
            <option value="9">9</option>
            <option value="10">10</option>
            <option value="11">11</option>
            <option value="12">12</option>
        </select> <br>
        <span v-show="false"> {{ CalcSumForPay(credit,months) }} </span>
        
        <table >
            <tr >
                <td>Nr. | </td>
                <td>Month's cost | </td>
                <td>Remaining </td>
            </tr>
            <tr v-for="nr in +months" :key="nr">
                <td>{{nr}}  </td>
                <td>{{ sumForPay.toFixed(2) }} </td>
                <td>{{(+CalcMonthsSum(credit).toFixed(2)  + +sumForPay).toFixed(2) }}</td>
            </tr>
        </table>
    </div>
    
</template>

<script>
export default ({
    data() {
      return {       
          credit : 0,
          months : 0,
          sumForPay : 0,
          contor : 0,
      }  
    },
    methods: {
        CalcSumForPay(credit,months){
            this.sumForPay = credit / months;
            return this.sumForPay;            
        },
        CalcMonthsSum(initialSumm){
            
            if(this.contor <= 0){
                this.contor = initialSumm
            }
            this.contor -= this.sumForPay
             return this.contor 
        },       
    },
    computed: {
    
    }
})
</script>

<style scoped>
input{
    width: 100px;
}
</style>
