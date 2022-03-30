<template>
    <div id="mainDiv">
        <input id="sum" type="number" min="1" max="4000" placeholder="Type a summ" v-model="TheValue" ><br>
        Select months: 
        <select itemid="months" name="" id="" v-model="TheMonths">
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
        <div ></div>
        <!-- <h2 v-if="TheValue > 0 & TheMonths > 0">{{ CalcSum() }}</h2> -->
        <h2 v-for="item in TheMonths" :key="item"> Sum for pay = {{ CalcSum(TheValue,TheMonths) }} // Months' Sum = {{ CalcMonthsSum() }}</h2>
        <div v-if="+TheMonths > 0">
        <div v-for="item in +TheMonths" :key="item">{{item}} {{CalcMonthsSum()}}</div>
        </div>
        
        <!-- <button @click="CalcSum()">doba</button> -->
        {{ sumForPay }} // {{ theBabki }}
        <!-- <h3 v-if=""></h3> -->
    </div>
    
</template>

<script>
export default ({
    data() {
      return {       
          TheValue : 0,
          TheMonths : 0,
          sumForPay : 0,
          theBabki : 0,
          contor : 0
      }  
    },
    methods: {
        CalcSum(TheValue,TheMonths){
            this.sumForPay = TheValue / TheMonths;
            return this.sumForPay;
            //this.theBabki = this.TheValue
            // if(this.theBabki > 0){
            //     this.theBabki -= this.sumForPay
            //     //h = document.createElement("div")
            //     let text = document.createTextNode(this.theBabki);
            //     document.getElementById("mainDiv").appendChild(text)
                
            // }
            // this.contor = this.sumForPay
            // for(let i = 0; i < this.TheMonths; i++){
            //     //this.theBabki.push(this.sumForPay);
            //     //console.log(this.sumForPay)
            //     this.theBabki.push(this.sumForPay)
            //     this.sumForPay += this.contor
            //     break;
            // }
            // this.contor = 0
            // console.log(this.theBabki)
             
        },
        CalcMonthsSum(){
            // if(this.contor > 0){
            //     return this.contor -= this.sumForPay
            // }else if(typeof(this.TheMonths) === NaN ){
            //     alert("dsa")
            // }else{
            //     return  this.contor = this.TheValue
            // }
                
            
            if(this.contor != 0){
                return this.contor -= this.sumForPay
            } else if (this.contor == 0) {
                return this.contor = this.TheValue
            } else {
                return this.contor = 0 
            }
        },
        test(){
            return this.contor++;
        }
        
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
