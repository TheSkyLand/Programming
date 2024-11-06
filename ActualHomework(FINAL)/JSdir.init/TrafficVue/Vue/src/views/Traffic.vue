<template>
    <div class="wrp">
        <TrafficLights active="green"/>
        <TrafficLights active="yellow" />
        <TrafficLights active="red" />
    </div>
</template>

<script setup>
import TrafficLights from "../components/TrafficLights.vue";
</script>

<style>
.wrp{
    height: 100vh;
    display: flex;
    flex-direction: column;
}
</style>