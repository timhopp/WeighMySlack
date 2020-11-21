<template>
  <div class="home">
    <h1 class="ml-5">Welcome To Weigh My Slack</h1>
    <div class="container-fluid">
    <div class="row">
      <h3 class="ml-5">Leash Rings</h3>
     <div class="col-12">

      <leashRings
        v-for="leashRingItem in leashRings"
        :leashRings="leashRingItem"
        :key="leashRingItem.id"
      ></leashRings>
     </div>
     
    </div>
    <div class="row">
      <h3 class="ml-5">Line Slides</h3>
      <div class="col-12">

    <lineSlide 
    v-for="lineSlideItem in lineSlides" 
    :lineSlide="lineSlideItem" 
    :key="lineSlideItem.id">
    </lineSlide>
      </div>
    </div>
     <div class="row">
      <h3 class="ml-5">Webbing Grips</h3>
      <div class="col-12">

    <webbingGrip
    v-for="webbingGripItem in webbingGrips" 
    :webbingGrip="webbingGripItem" 
    :key="webbingGripItem.id">
    </webbingGrip>
      </div>
    </div>
    <div class="row">
      <h3 class="ml-5">Manufacturers</h3>
      <div class="col-12">
      <manufacturer
        v-for="manufacturerItem in manufacturers"
        :manufacturer="manufacturerItem"
        :key="manufacturerItem.id"
      >
      </manufacturer>
      </div>
      
    </div>
    </div>
  </div>
</template>

<script>
import leashRings from "../components/leashRings";
import manufacturer from "../components/manufacturer";
import lineSlide from "../components/lineSlide";
import webbingGrip from "../components/webbingGrip";
export default {
  name: "home",
  computed: {
    user() {
      return this.$store.state.user;
    },
    leashRings() {
      return this.$store.state.leashRings;
    },
    manufacturers() {
      return this.$store.state.manufacturers;
    },
    lineSlides() {
      return this.$store.state.lineSlides;
    },
    webbingGrips(){
      return this.$store.state.webbingGrips;
    }
  },
  mounted() {
    this.$store.dispatch("getLeashRings");
    this.$store.dispatch("getManufacturers");
    this.$store.dispatch('getLineSlides');
    this.$store.dispatch('getWebbingGrips')
  },
  methods: {
    logout() {
      this.$store.dispatch("logout");
    },
  },
  components: {
    leashRings,
    manufacturer,
    lineSlide,
    webbingGrip
  },
};
</script>
