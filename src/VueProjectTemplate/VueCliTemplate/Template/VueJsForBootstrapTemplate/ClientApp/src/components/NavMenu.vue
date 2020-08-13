<template>
    <header>
        <b-navbar type="light" toggleable="sm" variant="white" class="navbar-toggleable-sm border-bottom box-shadow mb-3">
            <b-container>
                <b-navbar-brand to="/">VueJSTemplate</b-navbar-brand>
                <b-navbar-toggle target="nav-text-collapse" class="mr-2" />
                <b-collapse id="nav-text-collapse" class="d-sm-inline-flex flex-sm-row-reverse" is-nav>
                    <ul class="navbar-nav flex-grow">
                        <b-nav-item link-classes="text-dark" to="/">Home</b-nav-item>
                        <b-nav-item link-classes="text-dark" to="/counter">Counter</b-nav-item>
                        <b-nav-item link-classes="text-dark" to="/fetch-data">Fetch data</b-nav-item>
                    </ul>
                </b-collapse>
            </b-container>
        </b-navbar>
    </header>
</template>
<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';
    import './NavMenu.css';
    @Component
    export default class NavMenu extends Vue {
    }
</script>