<template>
    <div id="app">
        <NavMenu />
        <!--<div id="nav">
            <router-link to="/">Home</router-link> |
            <router-link to="/about">About</router-link>
        </div>-->
        <b-container>
            <router-view />
        </b-container>
    </div>
</template>

<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';
    import NavMenu from './components/NavMenu.vue';

    @Component({
        components: { NavMenu },
    })
    export default class App extends Vue {

    }
</script>