<template>
    <button @click="log">{{ num }}</button>
  </template>

<script setup>
defineProps({
    num:{
        type: Number,
        required: true
    }


    
})


// переменная
const msg = 'Hello!'

// функция
function log() {
  console.log(msg)
}
</script>

