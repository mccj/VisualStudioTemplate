<template>
    <div>
        <h1 id="tabelLabel">Weather forecast</h1>
        <p>This component demonstrates fetching data from the server.</p>
        <p v-if="loading"><em>Loading...</em></p>
        <b-table v-if="!loading" striped :items="forecasts" :fields="forecastCols" aria-labelledby="tabelLabel" />
    </div>
</template>

<script lang="ts">
    import { Component, Vue } from 'vue-property-decorator';
    import { IWeatherForecast } from '../models/IWeatherForecast';
    import axios from 'axios';

    @Component
    export default class FetchData extends Vue {
        private loading: boolean = true;
        private forecasts: IWeatherForecast[] = [{ summary: 'No data.' } as IWeatherForecast];
        private forecastCols: any[] = [
            { key: 'date', label: 'Date' },
            { key: 'temperatureC', label: 'Temp. (C)' },
            { key: 'temperatureF', label: 'Temp. (F)' },
            { key: 'summary', label: 'Summary' },
        ];

        public async mounted() {
            try {
                this.forecasts = (await axios.get('api/weatherforecast')).data;
            } catch {
                this.forecasts = [{ summary: 'No data.' } as IWeatherForecast];
            }
            this.loading = false;
        }
    }
</script>
