mbps_to_bps = int(1e6)

max_netw_bandw = 1000
max_netw_bandw_bps = max_netw_bandw * mbps_to_bps
print('Network capacity in bps:', max_netw_bandw_bps)

n_concurrent_users = 200
app_req_bandw = ((200000, 100000))
current_usage_bps = sum(app_req_bandw) * n_concurrent_users
print('The current usage in bps:', current_usage_bps)

available_network_bps = max_netw_bandw_bps - current_usage_bps
print('The current avalaibility:', available_network_bps)

new_app_req_bandw = 350000
new_apps_req_bandw = new_app_req_bandw * n_concurrent_users
print('The new applications requirement in bps:', new_apps_req_bandw)

available_network_bps_new_app = available_network_bps - new_apps_req_bandw
available_network_bps_new_app_mbps = available_network_bps_new_app / mbps_to_bps
print(
    'The bandwidth available if the new application is installed (in Mbps)',
    available_network_bps_new_app_mbps
)
