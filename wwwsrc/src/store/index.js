import Vue from "vue";
import Vuex from "vuex";
import Axios from "axios";
import router from "../router";

Vue.use(Vuex);

let baseUrl = location.host.includes("localhost")
  ? "https://localhost:5001/"
  : "/";

let api = Axios.create({
  baseURL: baseUrl + "api/",
  timeout: 3000,
  withCredentials: true,
});

export default new Vuex.Store({
  state: {
    leashRings: [],
    manufacturerLeashRings: [],
    manufacturers: [],
    myRigs: [],
    user: {},
  },
  mutations: {
    setManufacturers(state, manufacturers) {
      state.manufacturers = manufacturers;
    },
    setLeashRings(state, leashrings) {
      state.leashRings = leashrings;
    },
    setManufacturerLeashRings(state, manufacturerLeashRings) {
      state.manufacturerLeashRings = manufacturerLeashRings;
    },
    setUser(state, userInfo) {
      state.user = userInfo;
    },
    setMyRigs(state, myRigs) {
      state.myRigs = myRigs;
    },
  },
  actions: {
    setBearer({}, bearer) {
      api.defaults.headers.authorization = bearer;
    },
    resetBearer() {
      api.defaults.headers.authorization = "";
    },
    setUser({ commit }, userInfo) {
      commit("setUser", userInfo);
    },
    getManufacturers({ commit }) {
      api
        .get("manufacturers")
        .then((res) => commit("setManufacturers", res.data));
    },
    getLeashRings({ commit }) {
      debugger;
      api.get("leashrings").then((res) => commit("setLeashRings", res.data));
    },
    getLeashRingsByManufacturer({ commit }, manufacturerId) {
      api
        .get("manufacturers/" + manufacturerId + "leashrings")
        .then((res) => commit("setManufacturerLeashRings", res.data));
    },
    async addLeashRingsToRig({ commit, dispatch }, data) {
      try {
        let res = await api.post("");
      } catch (error) {
        console.error(error);
      }
    },

    async createRig({ commit, dispatch }, newRig) {
      try {
        let res = await api.post("rigs", newRig);
        console.log(res);
      } catch (error) {
        console.error(error);
      }
    },
    getMyRigs({ commit }) {
      api.get("rigs").then((res) => commit("setMyRigs", res.data));
    },
  },
});
