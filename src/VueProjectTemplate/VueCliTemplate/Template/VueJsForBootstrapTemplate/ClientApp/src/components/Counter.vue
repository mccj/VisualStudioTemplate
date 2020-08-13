<template>
    <div>
        <h1>Counter</h1>

        <p>This is a simple example of a Vue component.</p>

        <p aria-live="polite">Current count: <strong>{{currentCount}}</strong></p>

        <b-button variant="primary" @click="incrementCounter">Increment</b-button>
    </div>
</template>
<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';
    @Component
    export default class Counter extends Vue {
        private currentCount: number = 0;
        private incrementCounter() {
            this.currentCount += 1;
        }
    }
</script>